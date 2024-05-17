using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhone
{
    internal class Program
    {

        public static void Call(CellPhone phone1, CellPhone phone2)
        {
            if (phone1 != phone2)
            {
                phone1.MakeCall(phone2);
                phone2.GetCall(phone1);
            }
        }

        static void Main(string[] args)
        {
            CellPhone[] cellphones = new CellPhone[10];

            CellPhone cell1 = new CellPhone("0547783489", "avi", true);
            cellphones[0] = cell1;
            CellPhone cell2 = new CellPhone("0573385987", "Yossi", true);
            cellphones[1] = cell2;
            CellPhone cell3 = new CellPhone("0526670728", "Moshe", true);
            cellphones[2] = cell3;
            CellPhone cell4 = new CellPhone("0558908395", "Alon", false);
            cellphones[3] = cell4;
            CellPhone cell5 = new CellPhone("0537894783", "Yaron", true);
            cellphones[4] = cell5;
            CellPhone cell6 = new CellPhone("0532787789", "Refael", true);
            cellphones[5] = cell6;
            CellPhone cell7 = new CellPhone("0527784950", "Moti", true);
            cellphones[6] = cell7;
            CellPhone cell8 = new CellPhone("0557783957", "Amnon", false);
            cellphones[7] = cell8;
            CellPhone cell9 = new CellPhone("0527780909", "Adam", true);
            cellphones[8] = cell9;
            CellPhone cell10 = new CellPhone("0547789457", "Yotam", true);
            cellphones[9] = cell10;

            /*for (int i = 0; i < cellphones.Length; i++)
            {
                Console.WriteLine(cellphones[i]);
            }*/

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                CellPhone phone1 = cellphones[rnd.Next(10)];
                CellPhone phone2 = cellphones[rnd.Next(10)];

                if (phone1 == phone2)
                    i++;

                else
                {
                    Call(phone1, phone2);
                }

            }

            CellPhone maxIncoming = cellphones[0];
            CellPhone minOutgoing = cellphones[0];
            for (int i = 0; i < cellphones.Length; i++)
            {
                if (cellphones[i].GetNumOfIncoming() > maxIncoming.GetNumOfIncoming())
                    maxIncoming = cellphones[i];

                else if (cellphones[i].GetNumOfOutgoing() < minOutgoing.GetNumOfOutgoing())
                    minOutgoing = cellphones[i];
            }

            Console.WriteLine("The most Incoming calls: " + maxIncoming.GetName());
            Console.WriteLine("Calls list:");
            for (int i = 0; i < maxIncoming.GetNumOfIncoming(); i++)
            {
                Console.WriteLine(maxIncoming.GetIncomingCalls()[i].GetName());
            }

            Console.WriteLine("The list Outgoing calls: " + minOutgoing.GetName());
            Console.WriteLine("Calls list:");
            for (int i = 0; i < minOutgoing.GetNumOfOutgoing(); i++)
            {
                Console.WriteLine(minOutgoing.GetOutgoingCalls()[i].GetName());
            }
        }
    }
}
