using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentEngine.Domain.PageContent
{
    public class News
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime HighlightedTo { get; private set; }
        public string CreatedBy { get; private set; }
    }
}
