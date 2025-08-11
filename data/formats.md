# Input Formats

CSV files containing contact info sourced from different accounts in CRM systems. They can be identified by
the filename:

shortname_acctnum.csv

tp = TransactionPower
ms = MegaCorp Statics
cs = CenterSquare CRM

The CSV data comes from different sources, which may have different formats. We want the data to be standardized in the format below.

# Output Formats

## Contacts

| Name | Decription | Example |
| ---- | ---------- | ------- |
| Id | A unique identifier for this contact | 91be4da9-f545-470f-8c05-414323da8a4f |
| Name | The full name of the contact | John Doe |
| Email | The email address of the contact | john.doe@example.com |
| Phone | The phone number of the contact | 234-567-8901 |
| DataSource | The source of the contact data | TransactionPower |
| DataSourceAccountId | The account ID in the data source | 67890 |
| ModifiedAt | The date when the contact was last modified | 2023-10-01T12:34:56Z |

## Email (Advanced)

| Name | Description | Example |
| ---- | ----------- | ------- |
| Id | A unique identifier for this email | 8f14e45f-ea31-4b5b-8c2c-4f5c5e5c5e5c |
| Subject | The subject of the email | Meeting Reminder |
| Body | The body content of the email | Don't forget about the meeting tomorrow at 10 AM. |
| Sender | The sender's email address | john.doe@example.com |
| Recipients | The direct recipient's email addresses | [jane.smith@example.com, emily.johnson@example.com] |
| Cc | The CC'd email addresses | [bob.johnson@example.com, charlie.brown@example.com] |
| Bcc | The BCC'd email addresses | [alice.williams@example.com, joe.miller@example.com] |
| Attachments | Any files attached to the email | [proposal.pdf, budget.xlsx] |
| SentAt | The date and time when the email was sent | 2023-10-01T12:34:56Z |
| ParentMessageId | The ID of the parent message in a thread | 53e1f5c6-8b2c-4f5b-8c2c-4f5c5e5c5e5c |
