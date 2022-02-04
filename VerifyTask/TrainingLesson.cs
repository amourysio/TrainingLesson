using System;
using System.Collections.Generic;
using System.Text;

namespace VerifyTask
{
    public  class TrainingLesson : BaseEntity  , ICloneable , IVersionable
    {
        private List<BaseEntity> _trainingMaterials;
        private byte[] _version;



        public TrainingLesson(Guid Id, string Discription) : base(Id, Discription)
        {
            this._trainingMaterials = new List<BaseEntity>();
            this._version = new byte[0];
        }
        public void AddTrainingMaterial(BaseEntity material)
        {
            TrainingMaterials.Add(material);

        }
        public List<BaseEntity> TrainingMaterials
        {
            get { return _trainingMaterials; }
            set { _trainingMaterials = value; }
        }
        public byte[] Version
        {
            get { return _version; }
            set { _version = value; }
        }

        public new object Clone()
        {
            TrainingLesson lessen = new TrainingLesson(base.Id, base.Description);
            lessen.TrainingMaterials = new List<BaseEntity>();
            foreach (BaseEntity entity in TrainingMaterials)
            {
                lessen.TrainingMaterials.Add((BaseEntity)entity.Clone());
            }

            lessen.TrainingMaterials = TrainingMaterials;
            return lessen;
        }

        public byte[] GetVersion()
        {
           return Version;
        }

        public void SetVersion(byte[] version)
        {
            Version = version;
        }
    }
}
