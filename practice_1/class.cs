namespace spaceforpractice1
{    class CompteClass
    {
        public int Id { get; set;}
        public decimal Solde { get; set;}
        public CompteClass(int Id, decimal Solde)
        {
            this.Id = Id;
            this.Solde = Solde;
        }
    }

    record CompteRecord
    {
        public int Id { get; set; }
        public decimal Solde { get; set; }
        public CompteRecord(int Id, decimal Solde)
        {
            this.Id = Id;
            this.Solde = Solde;
        }
    }
}    