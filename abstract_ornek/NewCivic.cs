namespace abstract_ornek
{
    public class NewFocus:Otomobil
    {
        public override Marka HangiMarkanınAraci()
        {
            return Marka.Civic;
        }

        public override Renk StandartRengiNe()
        {
            return Renk.gri;
        }
    }
}