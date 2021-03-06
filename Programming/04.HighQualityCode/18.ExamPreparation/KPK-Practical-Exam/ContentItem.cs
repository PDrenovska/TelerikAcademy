﻿using System;
using System.Linq;

namespace CatalogOfFreeContent
{
    public class ContentItem : IComparable, IContent
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public Int64 Size { get; set; }

        private string url;

        public string URL
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
                this.TextRepresentation = this.ToString(); // To update the text representation
            }
        }

        public ContentItemType Type { get; set; }

        public string TextRepresentation { get; set; }

        public ContentItem(ContentItemType type, string[] commandParams)
        {
            this.Type = type;
            this.Title = commandParams[(int)ContentItemInfo.Title];
            this.Author = commandParams[(int)ContentItemInfo.Author];
            this.Size = Int64.Parse(commandParams[(int)ContentItemInfo.Size]);
            this.URL = commandParams[(int)ContentItemInfo.Url];
        }

        public int CompareTo(object obj)
        {
            if (null == obj)
                return 1;

            ContentItem otherContent = obj as ContentItem;
            if (otherContent != null)
            {
                int comparisonResul = this.TextRepresentation.CompareTo(
                    otherContent.TextRepresentation);

                return comparisonResul;
            }

            throw new ArgumentException(
                "Cannot compare Content with non content object");
        }

        public override string ToString()
        {
            string output = String.Format("{0}: {1}; {2}; {3}; {4}",
                this.Type.ToString(), this.Title, this.Author, this.Size, this.URL);

            return output;
        }
    }
}
