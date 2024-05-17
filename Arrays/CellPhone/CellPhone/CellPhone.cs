using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhone
{
    class CellPhone
    {
        private string num;
        private string name;
        private bool isOnline;
        private CellPhone[] incomingCalls;
        private CellPhone[] outgoingCalls;
        private int numOfIncoming;
        private int numOfOutgoing;


        public CellPhone(string num, string name, bool isOnline)
        {
            this.num = num;
            this.name = name;
            this.isOnline = isOnline;
            incomingCalls = new CellPhone[100];
            outgoingCalls = new CellPhone[100];
            numOfIncoming = 0;
            numOfOutgoing = 0;
        }

        public void SetNum(string num)
        {
            this.num = num;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void set_isOnline(bool isOnline)
        {
            this.isOnline = isOnline;
        }

        public string GetNum()
        {
            return this.num;
        }

        public string GetName()
        {
            return this.name;
        }

        public bool Get_isOnline()
        {
            return this.isOnline;
        }

        public CellPhone[] GetIncomingCalls()
        {
            return this.incomingCalls;
        }

        public CellPhone[] GetOutgoingCalls()
        {
            return this.outgoingCalls;
        }

        public int GetNumOfIncoming()
        {
            return this.numOfIncoming;
        }

        public int GetNumOfOutgoing()
        {
            return this.numOfOutgoing;
        }

        public override string ToString()
        {
            string s = "Name: " + this.name + ", number: " + this.num + ", Is Online: " + this.isOnline + ", Incoming calls: " + numOfIncoming + ", Outgoing calls: " + numOfOutgoing;
            return s;
        }

        public void MakeCall(CellPhone ToCell)
        {
            outgoingCalls[numOfOutgoing] = ToCell;
            numOfOutgoing++;
        }

        public void GetCall(CellPhone fromCell)
        {
            incomingCalls[numOfIncoming] = fromCell;
            numOfIncoming++;
        }
    }
}
