﻿using System;
using System.Collections.Generic;
using Winner.Selections.Domain;
using Winner.Selections.Domain.Comments;
using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace Winner.Feature.Selections.Models.Admin
{
    public class AwardModel : BaseModel
    {
        public TextField TitleLabel { get; set; }

        public TextField CommentsLabel { get; set; }

        public TextField ConfirmAwardLabelFormat { get; set; }

        public TextField ConfirmRemoveAwardLabelFormat { get; set; }

        public TextField CancelLabel { get; set; }

        public TextField ReturnLabel { get; set; }

        public TextField SuccessLabelFormat { get; set; }

        public TextField SuccessRemoveLabelFormat { get; set; }

        public TextField MvpTypeLabel { get; set; }

        public TextField WarningLabel { get; set; }

        public TextField ConfirmLabel { get; set; }

        public HyperLinkField ReturnLink { get; set; }

        public Guid TitleId { get; set; }

        public Title Title { get; set; }

        public Guid ApplicationId { get; set; }

        public Application Application { get; set; }

        public List<ApplicationComment> Comments { get; set; } = new ();

        public List<MvpType> MvpTypes { get; set; } = new ();

        public short MvpTypeId { get; set; }

        public string Warning { get; set; }

        public bool IsRemove { get; set; }

        public bool IsConfirmed { get; set; } = false;
    }
}
