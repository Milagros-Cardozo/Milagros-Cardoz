namespace _22_5_2020
{
    public class MaestroSangre : MaestroAgua
    {
        public MaestroSangre(int habilidad) : base(habilidad)
        {
            
        }
        public override bool esPeligroso() => true;
    }
}