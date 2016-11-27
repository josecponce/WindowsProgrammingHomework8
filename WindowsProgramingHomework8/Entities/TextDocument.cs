using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsProgramingHomework8.Entities
{
    [Serializable]
    public class TextsDocument
    {
        public List<Text> Texts { get; set; }
       
        [NonSerialized]
        public bool Dirty = false;

        public TextsDocument()
        {
            Texts = new List<Text>();
            Dirty = false;
        }
        public void AddText(Text text)
        {
            Texts.Add(text);
            text.PropertyChanged += Text_PropertyChanged;
            Dirty = true;
        }
        public void RemoveShape(Text text)
        {
            Texts.Remove(text);
            text.PropertyChanged -= Text_PropertyChanged;
            Dirty = true;
        }
        public int NextZOrder() {
            return (Texts.Count == 0) ? 0 : Texts.Max((text) => text.ZOrder) + 1;
        }

       
        private void Text_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Dirty = true;
        }
    }
}
