using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class IntroduceNullObject
    {
        public void Example()
        {
            var journal = new MagazineStore().Journal;
            string journalName = string.Empty;
            if (journal == null)
            {
                journalName = "AutoRia";
            }
            else
            {
                journalName = journal.Name;
            }
        }

        public void RefactoredExample()
        {
            var journal = new RefactoredMagazineStore().Journal;
            string journalName = journal.Name;
        }
    }

    //<----------- Ex 3 ----------->

    //Introduce Null Object

    class MagazineStore
    {
        public Journal Journal { get; private set; }
    }

    class Journal
    {
        public string Name { get; private set; }
    }

    //<----------- Refactored ----------->

    class RefactoredMagazineStore
    {
        private RefactoredJournal journal;
        public RefactoredJournal Journal
        {
            get
            {
                if (journal == null)
                {
                    return RefactoredJournal.CreateNull();
                }
                return journal;
            }
            private set { journal = value; }
        }
    }

    class RefactoredJournal
    {
        public virtual string Name { get; private set; }

        public virtual bool IsNull { get { return false; } }

        public static RefactoredJournal CreateNull()
        {
            return new NullJournal();
        }
    }

    class NullJournal : RefactoredJournal
    {
        public override string Name
        {
            get { return "AutoRia"; }
        }

        public override bool IsNull { get { return true; } }
    }
}
