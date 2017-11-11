using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyndaInterfacesDemo
{
    partial class Document : IStorable, IEncryptable
    {
        private string _name;
        private bool _mNeedsSave;
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropChanged(string propName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public Document(string s)
        {
            _name = s;
            Console.WriteLine($"Created a document with name {_name}.");
        }

        public void Save()
        {
            Console.WriteLine("Saving the document");
        }

        public void Load()
        {
            Console.WriteLine("Loading the document");
        }

        public bool NeedsSave
        {
            get { return _mNeedsSave; }
            set
            {
                _mNeedsSave = value;
                NotifyPropChanged("NeedsSave");
            }
        }

        public void Encrypt()
        {
            Console.WriteLine("Encrypting...");
        }

        public void Decrypt()
        {
            Console.WriteLine("Decrypting...");
        }

    }
}
