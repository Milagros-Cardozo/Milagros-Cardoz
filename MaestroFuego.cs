namespace _22_5_2020
{
    public class MaestroFuego : Maestro
    {
        private int rabia;
        private int locura;

        public MaestroFuego(int habilidad, int rabia, int locura) : base(habilidad)
        {
            this.rabia = rabia;
            this.locura = locura;
        }

        //override: pisa el metodo de la superclase
        public override int poder(){
            return rabia/locura;
        }
    }
}