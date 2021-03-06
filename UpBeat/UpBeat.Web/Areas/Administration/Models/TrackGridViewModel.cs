﻿using System.ComponentModel.DataAnnotations;
using UpBeat.Common.Constants;
using UpBeat.Common.Mappings;
using UpBeat.Data.Models;

namespace UpBeat.Web.Areas.Administration.Models
{
    public class TrackGridViewModel : IMapFrom<Track>
    {
        public int Id { get; set; }

        [StringLength(DataConstants.MaxModelNameLength,
            MinimumLength = DataConstants.MinModelNameLength,
            ErrorMessage = ErrorMessages.FormName)]
        public string Name { get; set; }

        [RegularExpression(DataConstants.UrlRegex, ErrorMessage = ErrorMessages.FormLink)]
        public string PreviewUrl { get; set; }
    }
}