using System;

namespace Курсы
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Pdirector : Video
    {
        public string Name;
    }
    class Painter : Picter
    {
        public string Name;
    }
    class Singer:Song
    {
        public string Name;
    }
    abstract class Media:Action
    {
        public abstract void extension();
        public abstract void name();
        public abstract void path();
        public abstract void quality();   
    }
    class Video:Media
    {
        public override void extension() { }
        public override void name() { }
        public override void path() { }
        public override void quality() { }
    }
    class Song : Media
    {
        public override void extension() { }
        public override void name() { }
        public override void path() { }
        public override void quality() { }
    }
    class Picter : Media
    {
        public override void extension() { }
        public override void name() { }
        public override void path() { }
        public override void quality() { }
    }
    class Action : Delete, Add, Search
    {
        public void delete(){}
        public void add() { }
        public void search() { }
    }
    interface Delete
    {
        void delete();
    }
    interface Add
    {
        void add();
    }
    interface Search
    {
        void search();
    }

}
