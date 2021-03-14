# Space Project

### Main Activities

- create space crew members 
- boss from MCC create mission and mission to astronaut
- astronaut receive the mission and do further tasks 
  - pick the rocket based on the type of task
    - can choose a rocket directly, or alternatively, DIY rocket using RocketParts 
  - drive the rocket
  - do tasks



### Domain

**Astronaut**

- id, 

- name, 

- role **ENUM** 
  - Pilot, 
  - Mission Specialist,
  -  Payload Specialist

**Rocket**

- id, 
- name
- type **ENUM**
  - super heavy-lift launch vehicle.

**Capacity**

- 12 full-grown elephants

**RocketParts**

- [] noseCone, 
- body, 
- engine, 
- fins, 

**Mission**

- id, 

- name, 
- description, 
- peronInCharge, 
- budget, 
- createDate, 
- expirationDate
- MissionType **ENUM**
  - research
  - Asteroid mining
  - Satellites
  - tourism

**MissionDetail** (specific tasks)

**Location**

​	Latitude Longitude Altitude 







