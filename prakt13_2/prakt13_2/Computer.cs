namespace prakt13_2
{
    class Computer
    {
        private string pcnumber;
        private string processor;
        private string monitor;
        private string videok;
        private int op;
        private string dota;

        public Computer(string pcnumber, string processor, string monitor, string videok, int op, string dota)
        {
            this.pcnumber = pcnumber;
            this.processor = processor;
            this.monitor = monitor;
            this.videok = videok;
            this.op = op;
            this.dota = dota;
        }

        public string getPcNumber()
        {
            return this.pcnumber;
        }
        public string getProcessor()
        {
            return this.processor;
        }
        public string getMonitor()
        {
            return this.monitor;
        }
        public string getVideok()
        {
            return this.videok;
        }
        public int getOp()
        {
            return this.op;
        }
        public string getDota()
        {
            return this.dota;
        }

        public void setPcNumber(string pcnumber)
        {
            this.pcnumber = pcnumber;
        }
        public void setProcessor(string processor)
        {
            this.processor = processor;
        }
        public void setMonitor(string monitor)
        {
            this.monitor = monitor;
        }
        public void setVideok(string videok)
        {
            this.videok = videok;
        }
        public void setOp(int op)
        {
            this.op = op;
        }
       

        internal object setDota()
        {

            if (op > 4)
            {
                this.dota = "Да";
                return dota;
            }
            else
            {
                this.dota = "Нет";
                return dota;
            }



        }
    }
}
