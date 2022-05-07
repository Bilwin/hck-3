using System;

namespace HackatonProject.Models
{
    public class Publication
    {
        public Publication(int id, int organizationId, string text, DateTime createdAt, int attachmentsCount)
        {
            Id = id;
            OrganizationId = organizationId;
            Text = text;
            CreatedAt = createdAt;
            AttachmentsCount = attachmentsCount;
        }

        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public int AttachmentsCount { get; set; }
    }
}