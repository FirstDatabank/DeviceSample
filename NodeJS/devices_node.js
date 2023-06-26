const axios = require('axios');

// Replace these constants with the credentials provided by FDB
const baseAddress = 'https://api.fdbprizm.com/mdp/api/v1_2/';
const clientId = 'REPLACE_THIS_TEXT_WITH_YOUR_PROVIDED_CLIENT_ID';
const secret = 'REPLACE_THIS_TEXT_WITH_YOUR_PROVIDED_SECRET';

class Program {
    
	static async  getDevices() {
		try {
			const client = axios.create({
				baseURL: baseAddress,
				headers: {
					'Authorization': `SHAREDKEY ${clientId}:${secret}`,
					'Accept': 'application/json'
				}
			});
			
			const request = 'devices?limit=100&offset=1&callSystemName=ConsoleAppExample';
			//OTHER EXAMPLES:
                //Here is an example of searching for a GTIN14
                //const request = 'devices?searchFilter=GTIN14:09420012421777&callSystemName=ConsoleAppExample';

                //Here is an example of searching for a HIBC
                //const request = 'devices?searchFilter=HIBC:H67141496090&callSystemName=ConsoleAppExample';

                //Here is an example of searching for any identifier (GTIN, HIBC, NDC/NHRIC, UPN etc.)
                //const request = "devices?searchFilter=Packages.PackageIdentifiers.ExternalPackageId:00709078060014&callSystemName=ConsoleAppExample";

                ////Here is an example of searching for HCPCSCode
                //const request = "devices?searchFilter=HCPCS.HCPCSCode:K0738&callSystemName=ConsoleAppExample";

                //Here is an example where you are searching and you don't necessarily know the type
                //const request = 'devices?searchText=H67141496090&searchType=Fuzzy&callSystemName=ConsoleAppExample';

                //Here is an example where you are searching for CatalogNumber
                //const request = "devices?searchFilter=CatalogNumbers.CatalogNumber:47-2347-123-00&callSystemName=ConsoleAppExample";
				
				//Here is an example where you are searching for a date range
                //const request = "devices?searchFilter=PrizmPublishDate:[2021-07-05 TO 2021-07-09]&callSystemName=ConsoleAppExample";

				
			const response = await client.get(request);
			//Look for a 200 status code.  400 level status codes indicate something went wrong that a client could potentially fix.
                // For example, 401 unauthorized, or 404 not found.
                // 500 level errors indicate that something went wrong on the server side.
			if (response.status === 200) {
				const r = response.data;
				console.log(r);
				r.Items.forEach(device => {
					console.log(device.StandardDeviceName);
				});
				
				 if (r.Items.length == 0) {
					console.log('No Records found with the search criteria.');
				}
			} else {
				console.log(`Call Failed, reason: ${response.statusText}`);
			}
		} catch (error) {
			console.error(`Error: ${error.message}`);
		}
		console.log('Press Enter to Exit.');
		process.stdin.once('data', () => process.exit());
	}


    static async main() {
        await Program.getDevices();
    }
}

Program.main();