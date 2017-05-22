﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using RawSharer.Models.Entities.Base;
using RawSharer.Models.Entities.Storage;

namespace RawSharer.Models.Entities.Music
{
    public class TrackVersion : Entity
    {
        [MaxLength(128)]
        [Index(IsClustered = false, IsUnique = false)]
        public string Name { get; set; }

        public virtual Track Track { get; set; }
        public virtual LocalBlob OriginalStorage { get; set; }
        public virtual LocalBlob ConvertedStorage { get; set; }
        public virtual Lyrics Lyrics { get; set; }

        public TrackVersion(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public TrackVersion()
        {
            // Reserved For Serialization
        }
    }
}