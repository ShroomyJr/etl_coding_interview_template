# Input Formats

CSV files containing contact info sourced from different accounts in CRM (Customer Relationship Manager) systems. 
These are sales contacts from external systems for which we want to aggregate data.

These files follow a specific naming convention you can rely on:

shortname_acctnum.csv

tp = TransactionPower
ms = MegaCorp Statics
cs = CenterSquare CRM

The CSV data comes from different external sources, which may have different formats. We want the data to be standardized in the format below.

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
