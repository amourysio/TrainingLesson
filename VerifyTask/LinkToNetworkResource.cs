using System;
using System.Collections.Generic;
using System.Text;

namespace VerifyTask
{
    internal class LinkToNetworkResource : BaseEntity
    {
        public string _contentURI;
        public LinkType _linkType;
        public LinkToNetworkResource(Guid Id, string Discription, string ContentURI, LinkType LinkType) : base(Id, Discription)
        {
            this._contentURI = ContentURI;
            this._linkType = LinkType;
        }
        public string ContentURI
        {
            get { return _contentURI; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Empty String");
                }
                else
                {

                    _contentURI = value;
                }
            }
        }
        public LinkType LinkType
        {
            get { return _linkType; }
            set { _linkType = value; }
        }
    }
}
