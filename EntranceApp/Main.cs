/*=======================================================================================================================
    Parking System Project - IMSE3019 - Entrance Application

    Created by  : Felipe Alamos
    Date        : 2nd December 2014
    Remark      :                   
        1. The project is based in the project developed by Bill Chan, imseWCard2, for IMSE3019 Smart Card Laboratory.

        2. The reference imseWSC1K should be added.

        3. The current application enables the Entrance Gate to administrate the parking card.

        4. The 1st block of Sector 14 is used to save the card id. THe 2nd block of Sector 14 is used to save the car patent.
           The 3rd block of Sector 14 is used to save the entrance time.

        5. The 3 blocks of Sector 15 are used to save the amounts of the 3 biggest purchases, i.e. blocks 0x3C, 0x3D, 0x3E
*///=======================================================================================================================


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using imseWSC1K;  // the class library for contactless smart card

namespace imseWCard2
{
    public partial class Main : Form
    {
        // create an object to handle the card
        private wSCard CADw = new wSCard();

        // true if a smart card is connected. Otherwise, false. 
        private bool connected = false;

        // true if a transaction is done. Reset to false if a connection is lost.
        private bool transectionDone = false;

        // Block 0, 1 and 2 of sector 15, i.e. block 0x3Cx, 0x3D, 0x3E, are used to save the biggest purchases
        private int amountsSector = 15;
        private int amount0Block = 0x3C;
        private int amount1Block = 0x3D;
        private int amount2Block = 0x3E;

        //Block 0 of sector 14, i.e block 0x38, is used to save card ID. Block 1, i.e block 0x39, is used to save car patent.
        //Block 2, i.e. block 0x3A is used to save the time of entrance

        private int informationSector = 14;
        private int cardIdBlock = 0x38;
        private int carPatentBlock = 0x39;
        private int entranceTimeBlock = 0x3A;


        //Parking fees
        private int PricePerHour = 30;

        //Free hour policy. 400 Dollars = 5 free hours (Combo1). 200 Dollares = 2 free hours (Combo2). No accumulative. Money in cents
        private int combo1freeHours = 5;
        private int combo1MoneyNeeded = 40000;
        private int combo2freeHours = 2;
        private int combo2MoneyNeeded = 20000;

        //True when the card has already been ejected.
        private bool ejected = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            unDisplayInformation();
            
            if (!CADw.initialize())  // initialize the object CADw
            {
                textBoxMsg.Text = "Reader initialization failed! Please call for asistance.";
                return;
            }
            timer1.Enabled = true;

            textBoxMsg.Text = "No card available. Please call for asistance";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!CADw.connect())
            {
                announceDisconection();
            }
            else
            {
                if (!connected)
                {
                    announceConnection();
                    btnEject.Enabled = true;
                }
            }
        }

        private void btnEject_Click(object sender, EventArgs e)
        {

            if (authenticateSector(amountsSector))
                resetAmountMemoryValues();

            if (authenticateSector(informationSector))
            {
                //In case there is old information written on it
                resetCardInformation();

                string cardId = assignCardId();

                string carPatent = readAndWriteCarPatent();

                assignEntranceTime();

                saveCardInLocalFile(cardId, carPatent);

                displayInformation();

                ejectCard();

                textBoxMsg.Text = "Please take your card";

                btnEject.Enabled = false;
            }

        }

        private void unDisplayInformation()
        {
            cardInformationStaticLabel.Visible = false;
            cardIdStaticLabel.Visible = false;
            carPatentStaticLabel.Visible = false;
            entranceTimeStaticLabel.Visible = false;

            cardIdLabel.Text = "";
            carPatentLabel.Text = "";
            entranceTimeLabel.Text = "";
        }

        private void displayInformation()
        {
            string cardId = "";
            string carPatent = "";
            string entranceTime = "";

            if (CADw.read(cardIdBlock, ref cardId) == false || CADw.read(carPatentBlock, ref carPatent) == false ||
                CADw.read(entranceTimeBlock, ref entranceTime) == false)
            {
                textBoxMsg.Text = "Read value error!";
                return;
            }

            // Display the information 
            cardInformationStaticLabel.Visible = true;
            cardIdStaticLabel.Visible = true;
            carPatentStaticLabel.Visible = true;
            entranceTimeStaticLabel.Visible = true;

            cardIdLabel.Text = cardId;
            carPatentLabel.Text = carPatent;

            if (entranceTime != "") //sometimes the entranceTime might be "" if the card was just taken away.
            {
                string[] time = entranceTime.Split('_');
                entranceTimeLabel.Text = time[0] + " " + time[1];
            }
        }

        private bool authenticateSector(int sector)
        {
            if (CADw.authenticate(sector) == false)
            {
                textBoxMsg.Text = "Authentication error!";
                return false;
            }
            return true;
        }

        private void announceConnection()
        {
            connected = true;
            textBoxMsg.Text = "Welcome! Press eject card buttom";
        }

        private void announceDisconection()
        {
            if (connected && !ejected)
            {
                textBoxMsg.Text = "Lost connection! Please call for asistance.";
            }

            // Connection lost.
            if (connected && ejected)
            {
                textBoxMsg.Text = "Bye Bye! Enjoy your shopping! Gate opening..";
                ejected = false;
                openGate();
            }

            unDisplayInformation();
            btnEject.Enabled = false;
            connected = false;
            return;
        }

        private void openGate()
        {
            //Physical opening of gate
        }

        private void resetAmountMemoryValues()
        {
            CADw.updateValueBlock(amount0Block, 0);
            CADw.updateValueBlock(amount1Block, 0);
            CADw.updateValueBlock(amount2Block, 0);
        }

        private void resetCardInformation()
        {
            CADw.write(cardIdBlock, "");
            CADw.write(carPatentBlock, "");
            CADw.write(entranceTimeBlock, "");
        }

        private string toDollar(long amount)
        {
            /* The value stored in the card is in cents. Convert the value to dollar
             * */

            string str = "";

            if (amount <= 0)
                str = "0";
            else if (amount < 10)
                str = "0.0" + amount.ToString();
            else if (amount < 100)
                str = "0." + amount.ToString();
            else
            {
                int dollar = (int)amount / 100;
                int cent = (int)amount % 100;

                str = dollar.ToString();
                str += ".";
                if (cent == 0)
                    str += "00";
                else
                    str += cent.ToString();
            }
            return str;
        }

        private void saveCardInLocalFile(string cardId, string carPatent)
        {
            string path = @"cards-patents.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("Record of all cards-car´s patent pairs.");
                tw.WriteLine("***********");
                tw.Close();
            }
            TextWriter tw2 = new StreamWriter(path,true);
            tw2.WriteLine(cardId+';'+carPatent);
            tw2.Close();

        }

        private void assignEntranceTime()
        {
            System.DateTime entranceTime = System.DateTime.Now;

            string date = entranceTime.ToShortDateString();
            string time = entranceTime.ToShortTimeString();
            string date_time = date + "_" + time;

            CADw.write(entranceTimeBlock, date_time);
        }

        private void ejectCard()
        {
            //phisical ejection of card
            ejected = true;
            return;
        }

        private string readAndWriteCarPatent()
        {
            string carPatent = cameraGetCarPatent();
            CADw.write(carPatentBlock, carPatent);
            return carPatent;
        }

        private string cameraGetCarPatent()
        {
            //Here the camera reads the car patents and returns the value.
            //Now we just return a random string of length 6
            return randomString(7);
        }

        private string randomString(int size)
        {
            Random _rng = new Random();
            string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
    
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = _chars[_rng.Next(_chars.Length)];
            }
            return new string(buffer);
        }
        
        private string assignCardId()
        {
            string cardId = getNewCardId();
            CADw.write(cardIdBlock, cardId);
            return cardId;
        }

        private string getNewCardId()
        {
            //We assign the next valid ID.
            //First read last ID assigned
            string path = @"cards-patents.txt";
            if (!File.Exists(path))
                return "1";
            
            int lastId = int.Parse(File.ReadLines("cards-patents.txt").Last().Split(';')[0]);
            int currentId = lastId + 1;
            return currentId + "";
        }
    }

}
