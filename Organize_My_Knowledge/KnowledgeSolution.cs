using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Organize_My_Knowledge
{
    class KnowledgeSolution
    {
        static TextBox Topic = new TextBox();
        static TextBox Description = new TextBox();
        static TextBox Solution = new TextBox();

        public KnowledgeSolution(TextBox Topic1, TextBox Description1, TextBox Solution1)
        {
            Topic = Topic1;
            Description = Description1;
            Solution = Solution1;
        }

        public TextBox ReturnTopic()
        {
            return (Topic);
        }

        public TextBox ReturnDescription()
        {
            return (Description);
        }

        public TextBox ReturnSolution()
        {
            return (Solution);
        }

        public bool CompareTopic(TextBox newTopic)
        {
            if (newTopic.Text == Topic.Text)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public bool CompareDescription(TextBox newDescription)
        {
            if (newDescription.Text == Description.Text)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}
