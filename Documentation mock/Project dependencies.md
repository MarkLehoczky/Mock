```mermaid
flowchart BT

Models --> Repository
Models --> Client
Models --> Endpoint
Repository --> Endpoint
Logic --> Endpoint
Models --> Logic
Repository --> Logic
Logic --> Test
Repository --> Test
Models --> Test
```
