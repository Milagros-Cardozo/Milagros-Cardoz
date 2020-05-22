namespace _22_5_2020
{
    public class MaestroAgua : Maestro
    {

        public MaestroAgua(int habilidad) : base(habilidad)
        {
            
        }

        public override int poder(){
            return habilidad*100;
        }

        public override bool esPeligroso(){
            return this.poder() > 100;
        }
    }
}