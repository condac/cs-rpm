# cs-rpm
Cities Skylines Realistic Power Mod

#  About
The game creators have a vary strange stance to favor solar power so much that the best power plan based on all factors is always the solar power. This takes out all realism and any gameplay where you want to build up to something better over time as your city grows. There is no real punish for using coal or oil from a pollution standpoint in the game. There is no reason to use hydroplants because they are the most expensive per MW in the game, as in real life they are the cheapest. There is so many things that are wrong with the powerplants and the games dynamic around the gameplay that it makes me sad. 

# Design rules
Because the game has no power banks or any good way to handle variating power loads, all power plants numbers are based on real life year average and output a constant power. Most data is taken from Sweden and Finnland ( I live there and these are very hydro, wind and nuclear based countries and the game developers are from Finnland so one would think they have used data from there own country). 

Also there is a need to keep the game progress fun so there must be small cheap alternatives early game. This is a reason to the size of the coal power beeing a bit smaller but cost factors should be realistic. 

# Cost
Cost is hard because there is no good value convertion and weekly cost is hard to estimate. But there is an average we can calculate and work from there. 

This is the part where you as a community can help calculate some numbers.

# Important difference between units and stations/plants
If you google biggest power plants you get a list that say that Kashiwazaki-Kariwa Nuclear Power Plant is the biggest nuclear power plant at 7965 MW. But this number is based on multiple power plants that are located at the area. We need to look at the individuial unit at the area. So in this case there is 7 nuclear power plants in this station at 1000-1300MW each. And this is the case for all coal/gas/oil plants/stations/units.


# Powerplants reallife comparision
Here is the list of the powerplants in the game and whats wrong with them compared to real life...

Lots of data is just straight from wikipedia where there is no reason do doubt the technical validity of the data. 

## Basic Wind Turbine

Wind data is based on wind tubines in Sweden duing 2014 and 2018. The average installed size between these dates is 3.45 MW per turbine. During the year the average power production is 25% of the installed power capacity. This makes each plant around 0.86MW.  The manufacturers claim that 2018 was not a normal wind year so the productivity is expected to be around 30% so for simplicity we round the numbers to 1MW. 

The scale of the drawn asset compared to real life and the space allowed between looks ok, so no scale modifier is used. 

So this one is easy to make a final result of 1MW per plant.

|                  | Game | Reallife | Mod |
|------------------|------|----------|-----|
| Power output    | 8  |  0.86  |  1   |
| Cost per MW     |    |        |      |
| Upkeep          |  80  |    ?    |  ?   |

## Advanced Wind Turbine
This powerplant is treated as the best case scenario and most technically advanced we can find in wind power. So i googled world largest wind turbine and found: Haliade-X 12 MW

Beeing offshore it have an expected year average production of 63%

|                  | Game | Reallife | Mod |
|------------------|------|----------|-----|
| Power output    | 20  |  7.56  |  7.56   |
| Cost per MW     |  ?  |   ?     |     ? |
| Upkeep          |  200  |    ?    |  ?   |
| MW per cell | ? | ? | ? |

## Coal Power Plant
The coal power plant is a starter plant, the asset is also taking a small area. This have made med to look for smaller installation of coal plants as reference. 

Coal plants are very flexible in size because you boil water and spin a turbine so you can adjust the size of the turbine to match you needs, some plants have more than one turbine connected to one boiler making the biggest boilers in the world output over 1000MW

China is the biggest user of Coal plants so looking around i can find large powerstations that have units of 600MW as the average size. But this is a starter plant for the game so we need to look small. But there are some plants 300MW in size. And with some scale factors this can probably end up as a smaller plant in game. 

The scale of a 7000MW station including coalstorage and train depot is 1.0x1.0km. The chineese know how to build compact that is for sure when you look at some satelite photos of the areas. This makes the power per area to 0.007MW/m^2. making it 0.448 MW/tile in game based on 8x8m tiles.  
If we look at the bare minimum of the boiler and turbine and ignore all area for coal storage and trains the boilers and turbines for a 1000MW plant is 250x130m (this is what you can see in the game asset). This makes it 1.97 MW/tile.

So with some scale modifications this asset should be around 60MW

30 tiles big asset.

|                  | Game | Reallife | Mod |
|------------------|------|----------|-----|
| Power output    | 40  |  300-1000  |  60   |
| Cost per MW     |  ?  |   ?     |     ? |
| Upkeep          |  560  |    ?    |  ?   |
| MW per tile | 1.34 | 0.448-1.97 | ? |



## Solar power plant
1000w/m² is the total power the suns rays under the most optimal condition, this means that solar power can never be better than 0.064MW/tile if the solar catching unit have 100% efficency, but solar panels have at max 20%. 0.0128 MW/tile.

The power plant shown in the asset is of a heat tower model. It use mirrors and focus heat and then boils water or heat molten salt. This gives it a rough efficency of 50% in the molten salt to turbine convertion. 

Looking at the asset the tower looks like the 20MW models in spain, it uses 930x1040m area so in reality we get ~0.00002MW/m²
And the next thing is that the sun is not shining all the time making the Capacity factor	27%. We end up with about 0.0000054MW/m². This makes the solar power in game about 3000 times more powerfull than real life when scaled to the game.

I have not worked out a good scale factor but making it 1:1 this would make the plant in game 0.05MW

|                  | Game | Reallife | Mod |
|------------------|------|----------|-----|
| Power output    | 160  |  10-20  |  0.05   |
| Cost per MW     |  ?  |   ?     |     ? |
| Upkeep          |  1200  |    ?    |  ?   |
| MW per tile | 1.12 | 0.0003456 | ? |


## Solar Updraft Tower
This is a joke.... The asset is showing a prototype plant built in the 80s that produced a peak power of 0.05MW, yet the game developers put this thing at 240MW... converting the peak power to total average power with the same capacity factor as the molten salt plant we get a power of 0.0135MW

|                  | Game | Reallife | Mod |
|------------------|------|----------|-----|
| Power output    | 240  |  0.0135  |  0.0135   |
| Cost per MW     |  ?  |   ?     |     ? |
| Upkeep          |  2240  |    ?    |  ?   |
| MW per tile | 1.54 | ? | 0.000087 |


