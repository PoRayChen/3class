using System;
using System.Collections.Generic;
using System.Text;

namespace _3class
{
    public interface IYouTuber{
        string Name { get; set; }
        void Say(string message);
        void SayFamousLine(IYouTuber destination);
        void SayCommon(IYouTuber destination); 
        }
    public abstract class YouTuber : IYouTuber, IEquatable<IYouTuber>
    {
        protected string _name;
        public string Name { get { return this._name; } set { throw new InvalidOperationException("Name is a read-only property."); } }
        public virtual string Sound1 { get { return string.Empty; } }
        public virtual string Sound2 { get { return string.Empty; } }
        public virtual string Sound3 { get { return string.Empty; } }
        public bool Equals(IYouTuber otherYouTuber) { return (this == otherYouTuber); }
        public void Say(string message) { Console.WriteLine(String.Format("{0} says: {1}", this.Name, message)); }
        public void SayFamousLine(IYouTuber destination) { Console.WriteLine(String.Format("{0} says goodbye to {1}: {2} {3} {4}", this.Name, destination.Name, Sound1, Sound3, Sound1)); }
        public void SayCommon(IYouTuber destination) { Console.WriteLine(String.Format("{0} welcomes {1}: {2}", this.Name, destination.Name, Sound2)); }
    }
}
