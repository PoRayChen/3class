using System;
using System.Collections.Generic;
using System.Text;

namespace _3class
{
    public class Party<T> where T : IYouTuber
    {
        private List<T> _members;
        public T Leader { get; private set; }
        public Party(T leader) { this.Leader = leader; this._members = new List<T>(); this._members.Add(leader); }
        public void AddMember(T member) 
        {
            this._members.Add(member);
            Leader.SayCommon(member); 
        }
        public bool RemoveMember(T member)
        {
            if (member.Equals(this.Leader))
            { throw new InvalidOperationException("You cannot remove the leader from the party."); }
            var result = this._members.Remove(member); if (result)
            { member.SayFamousLine(this.Leader); }
            return result;
        }
    }
}
