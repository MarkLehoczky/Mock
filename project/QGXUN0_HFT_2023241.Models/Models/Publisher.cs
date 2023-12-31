﻿using Newtonsoft.Json;
using QGXUN0_HFT_2023241.Models.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace QGXUN0_HFT_2023241.Models.Models
{
    /// <summary>
    /// Contains a publisher's name, books, and optionally website
    /// </summary>
    public class Publisher : IComparable<Publisher>, IComparable<string>, IComparable, IEquatable<Publisher>
    {
        /// <summary>
        /// Unique key value
        /// </summary>
        /// <remarks>Database Key</remarks>
        [JsonPropertyName("PublisherID")]
        [JsonProperty("PublisherID")]
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PublisherID { get; set; }

        /// <summary>
        /// Name of the publisher
        /// </summary>
        [JsonPropertyName("PublisherName")]
        [JsonProperty("PublisherName")]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string PublisherName { get; set; }

        /// <summary>
        /// Books of the publisher
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();

        /// <summary>
        /// Website of the publisher
        /// </summary>
        [JsonPropertyName("Website")]
        [JsonProperty("Website")]
        [StringLength(250, MinimumLength = 1)]
        [Website]
        public string Website { get; set; }


        /// <summary>
        /// Empty constructor
        /// </summary>
        public Publisher() { }
        /// <summary>
        /// Constructor with required property values
        /// </summary>
        /// <param name="publisherID">Unique key</param>
        /// <param name="publisherName">Publisher name</param>
        public Publisher(int publisherID, string publisherName)
        {
            PublisherID = publisherID;
            PublisherName = publisherName;
        }
        /// <summary>
        /// Constructor with required and optional property values
        /// </summary>
        /// <param name="publisherID">Unique PublisherID key</param>
        /// <param name="publisherName">Publisher name</param>
        /// <param name="website">Publisher website</param>
        public Publisher(int publisherID, string publisherName, string website)
        {
            PublisherID = publisherID;
            PublisherName = publisherName;
            Website = website;
        }


        /// <summary>
        /// Converts a <see cref="string"/> representation of a <see cref="Publisher"/> instance to a <see cref="Publisher"/> object
        /// </summary>
        /// <param name="data">Parsable data</param>
        /// <param name="splitString">Splitting string (default = ";")</param>
        /// <param name="restrictionCheck">Check for attribute restrictions (default = false)</param>
        /// <returns><see cref="Publisher"/> representation of the <paramref name="data"/> <see cref="string"/></returns>
        /// <exception cref="ArgumentException">Error during parsing</exception>
        /// <example><code>
        /// Publisher p1 = Publisher.Parse("1;Publisher name;www.website.com");
        /// Publisher p2 = Publisher.Parse("2$Publisher name", "$");
        /// Publisher p3 = Publisher.Parse("3;Publisher name;www.website.com", ";", true);
        /// </code></example>
        public static Publisher Parse(string data, string splitString = ";", bool restrictionCheck = false)
        {
            string[] splitData = data.Split(splitString);
            if (splitData.Length < 2)
                throw new ArgumentException("Not enough value after splitting the string, or the splitting was unsuccessful", nameof(data));

            if (!int.TryParse(splitData[0], out var publisherID))
                throw new ArgumentException("The 'PublisherID' property cannot be parsed to an 'int' type", nameof(data));

            string publisherName = splitData[1];

            bool hasWebsite = splitData.Length > 2;
            string website = hasWebsite ? splitData[2] : "";

            Publisher publisher;

            if (hasWebsite)
                publisher = new Publisher(publisherID, publisherName, website);
            else
                publisher = new Publisher(publisherID, publisherName);

            if (restrictionCheck)
                publisher.Validate();

            return publisher;
        }

        /// <summary>
        /// Attempts to convert a <see cref="string"/> representation of a <see cref="Publisher"/> instance to a <see cref="Publisher"/> object
        /// </summary>
        /// <param name="data">Parsable data</param>
        /// <param name="publisher"><see cref="Publisher"/> representation of the <paramref name="data"/> <see cref="string"/> or <see langword="null"/></param>
        /// <param name="splitString">Splitting string (default = ";")</param>
        /// <param name="restrictionCheck">Check for attribute restrictions (default = false)</param>
        /// <returns><see langword="true"/> if the parsing was successful, otherwise <see langword="false"/></returns>
        /// <example><code>
        /// bool isPublisher = Publisher.TryParse("1;Publisher name;www.website.com", out Publisher p1);
        /// Publisher p2 = null; Publisher.TryParse("2$Publisher name", out p2, "$");
        /// if (!Publisher.TryParse("3;Publisher name;www.website.com", out Publisher p3, ";", true)) { }
        /// </code></example>
        public static bool TryParse(string data, out Publisher publisher, string splitString = ";", bool restrictionCheck = false)
        {
            publisher = null;

            try { publisher = Parse(data, splitString, restrictionCheck); return true; }
            catch { return false; }
        }


        ///<inheritdoc/>
        public override string ToString()
        {
            if (Website != null)
                return $"[#{PublisherID}]{PublisherName} ({Website})";
            else
                return $"[#{PublisherID}]{PublisherName}";
        }

        ///<inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is not Publisher publisher) return false;
            else return Equals(publisher);
        }

        ///<inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(PublisherName, Books);
        }


        /// <inheritdoc/>
        public int CompareTo(Publisher other)
        {
            int comparer = Comparer.Default.Compare(PublisherName, other.PublisherName);
            if (comparer != 0) return comparer;

            comparer = Comparer.Default.Compare(Website, other.Website);
            return comparer;
        }

        /// <inheritdoc/>
        public int CompareTo(string other)
        {
            if (!TryParse(other, out var otherBook))
                return Comparer.Default.Compare(ToString(), other.ToString());
            else
                return CompareTo(otherBook);
        }

        /// <inheritdoc/>
        public int CompareTo(object obj)
        {
            if (obj is not Book)
                return CompareTo(obj.ToString());
            else
                return CompareTo(obj as Book);
        }

        /// <inheritdoc/>
        public bool Equals(Publisher other)
        {
            if (other == null) return false;
            else if (ReferenceEquals(this, other)) return true;
            else if (PublisherName != other.PublisherName) return false;
            else if (!Books.SequenceEqual(other.Books)) return false;
            else if (Website != other.Website) return false;
            else return true;
        }
    }
}
