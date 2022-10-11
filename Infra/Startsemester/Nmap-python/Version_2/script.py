import nmap3
import json

nmap = nmap3.Nmap()
nmap_scan = nmap3.NmapScanTechniques()

#IP_scan = input("Enter IP adress to scan: ")
IP_scan = '127.0.0.1'

results = nmap.scan_top_ports(IP_scan)

# Printing JSON
json_object = json.dumps(results['127.0.0.1']['ports'], indent = 4)
print(json_object)
