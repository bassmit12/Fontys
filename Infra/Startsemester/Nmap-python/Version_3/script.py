import nmap3
import json

nmap = nmap3.Nmap()
nmap_scan = nmap3.NmapScanTechniques()

IP_scan = input("Enter IP adress to scan: ")
#IP_scan = '127.0.0.1'
Port = input("Enter number of top ports to scan (max=10): ")
Port_scan = int(Port)

results = nmap.scan_top_ports(IP_scan)

# Printing JSON
print("--------------")
for i in range(Port_scan):
   json_object = json.dumps(results[IP_scan]['ports'][i], indent = 4)
   json_load = json.loads(json_object)
   if (results[IP_scan]['ports'][i]['state'] == 'open'):
      print("portid: ", json_load['portid'])
      print("state: ", json_load['state'])
      print("--------------")
