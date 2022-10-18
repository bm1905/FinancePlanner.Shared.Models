# FinancePlanner Application

# Architectures
![Alt text here](TaxServices-Project-Structure.png)

# Infrastructure setup commands
## Docker Up
`docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d`

## Docker Down
`docker-compose -f docker-compose.yml -f docker-compose.override.yml down`

## Docker Build
`docker-compose -f docker-compose.yml -f docker-compose.override.yml up --build`

# Ports Usage
## Reserved Ports for Docker
`1401 - SQL Server for Identity Server`  
`1402 - SQL Server for Tax Service` 
`5050 - PGAdmin GUI`   
`5432 - PostgreSQL`   
`5601 - Kibana GUI`  
`6779 - Redis`  
`8081 - Mongo GUI`  
`9000 - Portainer`  
`9200 - Elasticsearch`  
`27017 - Mongo Database`  

# Quick Links for Docker

## GUIs
Portainer - http://host.docker.internal:9000  
Mongo GUI - http://host.docker.internal:8081  
Kibana - http://host.docker.internal:5601  
Consul Service Discovery - http://host.docker.internal:8500  
PGAdmin GUI - http://host.docker.internal:5050    

## Services 
Elasticsearch - http://host.docker.internal:9200  