﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace CSETWebCore.Helpers.ReportWidgets
{
    public class QuestionsHeatMap
    {
        private XDocument _xSvgDoc;
        private XElement _xSvg;


        // the primary unit of measure, the width/height of a question block
        private int aaa = 20;

        private int gap1 = 2;
        // private int gap2 = 5;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="xGoal"></param>
        public QuestionsHeatMap(XElement xGoal)
        {
            _xSvgDoc = new XDocument(new XElement("svg"));
            _xSvg = _xSvgDoc.Root;

            // TODO:  TBD
            _xSvg.SetAttributeValue("width", 1000);
            _xSvg.SetAttributeValue("height", 400);

            // style tag
            var xStyle = new XElement("style");
            _xSvg.Add(xStyle);
            xStyle.Value = "text {font: .5rem sans-serif}";



            var gX = 0;

            // create questions
            foreach (var xQuestion in xGoal.Descendants("Question"))
            {
                if (xQuestion.Attribute("isparentquestion")?.Value == "true"
                    || xQuestion.Attribute("placeholder-p")?.Value == "true")
                {
                    continue;
                }

                // question group
                var question = MakeQuestion(xQuestion);
                question.SetAttributeValue("transform", $"translate({gX}, 0)");

                _xSvg.Add(question);

                // advance the X coordinate for the next question
                gX += aaa;
                gX += gap1;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private XElement MakeQuestion(XElement xQ)
        {
            var color = xQ.Attribute("scorecolor").Value;
            var text = WidgetResources.QLabel(xQ.Attribute("displaynumber").Value);

            var fillColor = WidgetResources.ColorMap.ContainsKey(color) ? WidgetResources.ColorMap[color] : color;
            var textColor = WidgetResources.GetTextColor(color);

            var g = new XElement("g");
            var r = new XElement("rect");
            var t = new XElement("text");

            g.Add(r);
            g.Add(t);

            r.SetAttributeValue("fill", fillColor);
            r.SetAttributeValue("width", aaa);
            r.SetAttributeValue("height", aaa);
            r.SetAttributeValue("rx", aaa / 6);

            t.Value = WidgetResources.QLabel(text);
            t.SetAttributeValue("x", aaa / 2);
            t.SetAttributeValue("y", aaa / 2);
            t.SetAttributeValue("dominant-baseline", "middle");
            t.SetAttributeValue("text-anchor", "middle");
            t.SetAttributeValue("fill", textColor);

            return g;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _xSvgDoc.ToString();
        }
    }
}