using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace VerifyTask
{
    public class BaseEntity: ICloneable
    {
        //[MaxLength(256)]
        //[Required(AllowEmptyStrings = false)]
        //[DisplayFormat(ConvertEmptyStringToNull = false)]
        public Guid _id;
        public string _description;

       public BaseEntity(Guid Id, string Discription)
        {
            this._id = Id;
            this._description = Discription;
        }

        
        public Guid Id
        {
            get { return this._id; }
            set { this._id = value; }
        
        }
        public string Description
        {
            get { return this._description; }
            set
            {
                if (_description.Length > 256)
                {
                    throw new ArgumentException("Description length is more than 256 characters");
                }
                else { this._description = value; }
            }
        }

        public object Clone()
        {
            return new BaseEntity(Id, Description);
        }
    }
}
