﻿using AmstaJanBonga.Web.Utilities;
using Rlaan.Toolkit.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Web.Content.PatientAgenda
{
    public partial class PatientAgenda : DefaultPage
    {
        DataTable agenda = new DataTable("Agenda");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                agenda.Columns.Add("Time");
                agenda.Columns.Add("Appointment");

                for (int i = 8; i <= 23; i++)
                {
                    DataRow workRow;
                    workRow = agenda.NewRow();
                    workRow[0] = "{0}:00".FormatString(i);

                    // 10:00 tot :12:00
                    if (i == 10)
                    {
                        var height = (38 + (50 * (12 - 10)));

                        workRow[1] = "<div class=\"appointment\" style=\"height: {0}px;\">".FormatString(height) +
                            "<dl><dt>Afspraak fysio</dt><dd><p>Tijdstip: Van 10:00 tot 12:00 uur.</p></dd><dd><p>Waar: Ruimte A.<p></dd><dd><p>Omschrijving: Maecenas convallis nisi at turpis auctor, aliquet molestie felis blandit.<p></dd></dl>"
                            + "</div>";
                    }
                    // 11:00 tot 12:00
                    if (i == 11)
                    {
                        var height = (38 + (50 * (12 - 11)));

                        workRow[1] = "<div class=\"appointment\" style=\"height: {0}px;\">".FormatString(height) +
                            "<dl><dt>Activiteit</dt><dd><p>Tijdstip: Van 11:00 tot 12:00 uur.</p></dd><dd><p>Waar: De woonkamer.<p></dd><dd><p>Omschrijving: Nulla mattis tellus vel est pellentesque dapibus. Pellentesque ornare lobortis pellentesque.<p></dd></dl>"
                            + "</div>";
                    }
                    // 14:00 tot 17:00
                    if (i == 14)
                    {
                        var height = (38 + (50 * (17 - 14)));

                        workRow[1] = "<div class=\"appointment\" style=\"height: {0}px;\">".FormatString(height) +
                            "<dl><dt>Familiebezoek</dt><dd><p>Tijdstip: Van 14:00 tot 17:00 uur.</p></dd><dd><p>Waar: De woonkamer.<p></dd><dd><p>Omschrijving: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum porttitor sollicitudin volutpat. Nulla consectetur neque id nulla dignissim, ac faucibus velit posuere.<p></dd></dl>"
                            + "</div>";
                    }
                    // 18:00 tot 19:00
                    if (i == 18)
                    {
                        var height = (38 + (50 * (18 - 18)));

                        workRow[1] = "<div class=\"appointment\" style=\"height: {0}px;\">".FormatString(height) +
                            "<dl><dt>Familiebezoek</dt><dd><p>Tijdstip: Van 18:00 tot 19:00 uur.</p></dd><dd><p>Waar: De woonkamer.<p></dd><dd><p>Omschrijving: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum porttitor sollicitudin volutpat. Nulla consectetur neque id nulla dignissim, ac faucibus velit posuere.<p></dd></dl>"
                            + "</div>";
                    }

                    agenda.Rows.Add(workRow);
                }

                this._repAgendaDay.DataSource = agenda;
                this._repAgendaDay.DataBind();
            }
        }
    }
}