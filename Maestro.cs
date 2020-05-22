namespace _22_5_2020
{
    //Abstract: Cuando una clase tiene metodo abstractos, se vuelve abstracta
    public abstract class Maestro
    {
        protected int habilidad;

        public Maestro(int habilidad)
        {
            this.habilidad = habilidad;
        }

        public abstract int poder();
        //Abstract: para implementar metodos que no tienen logica, solo para poner firma.

        public bool esGroso(){
            return this.poder() > 1000 && habilidad > 5;
        }

        //Virtual: sirve para que un metodo pueda sobreescribirse
        public virtual bool esPeligroso(){
            return false;
        }
    }
}