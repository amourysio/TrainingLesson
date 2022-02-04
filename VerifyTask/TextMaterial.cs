using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VerifyTask
{
    public class TextMaterial : BaseEntity 
    {
        //[Required]
        //[MaxLength(10000)]
        public string _text;
       

        public TextMaterial(Guid Id, string Discription, string Text) : base(Id, Discription)
        {
            this._text = Text;
        }
       public string Text
        {
           get { return Text; }
            set {
                if (_text.Length > 10000 || _text == string.Empty)
                    throw new ArgumentException("Empty String or Lenght is more than 10000 characters");
                else { _text = value; }
                }
            }
    }
}
