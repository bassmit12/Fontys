import nmap3
import json

nmap = nmap3.Nmap()
nmap_scan = nmap3.NmapScanTechniques()

#IP_scan = input("Enter IP adress to scan: ")
IP_scan = '127.0.0.1'

results = nmap.scan_top_ports(IP_scan)

# Printing JSON
print("--------------")
for i in range(5):
   json_object = json.dumps(results['127.0.0.1']['ports'][i], indent = 4)
   json_load = json.loads(json_object)
   print("portid: ", json_load['portid'])
   print("state: ", json_load['state'])
   print("--------------")
