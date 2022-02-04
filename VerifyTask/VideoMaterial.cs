using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VerifyTask
{
    public class VideoMaterial : BaseEntity , IVersionable
    {
        //[Required(string.Empty = false)]
        private string _videoContentURI;
        private string _splashScreenURI;
        private VideoFormatType _videoFormatType;
        private byte[] _version;
        public VideoMaterial(Guid id, string description,string VideoContentURI, string SplashScreenURI, VideoFormatType VideoFormatType) : base(id,description)
        {
            this._videoContentURI = VideoContentURI;
            this._splashScreenURI = SplashScreenURI;
            this._videoFormatType = VideoFormatType;
        }

        public string VideoContentURI
        {
            get { return _videoContentURI; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Empty String");
                }
                else
                {
                    _videoContentURI = value;
                }
            }
        }
        public string SplashScreenURI
        {
            get { return _splashScreenURI; }
            set { _splashScreenURI = value; }
        }
        public VideoFormatType VideoFormatType
        {
            get { return _videoFormatType; }
            set { _videoFormatType = value; }
        }
        public byte[] Version
        {
            get { return _version; }
            set { _version = value; }
        }
        public void SetVersion(byte[] version)
        {
            Version = version;
        }

        public byte[] GetVersion()
        {
            return Version;
        }
    }
}
