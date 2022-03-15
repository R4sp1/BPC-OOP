namespace Cviceni_6
{
    abstract class Objekt3D : GrObjekt           //Abstraktni trida rozsiruje (dedi) tridu GrObjekt
    {
        public abstract double SpoctiPovrch();   //U 3D objektu pocitame povrch a objem
        public abstract double SpoctiObjem();
    }
}