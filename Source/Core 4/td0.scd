SQLite format 3   @     �                                                                      �    ����                                                                              �b�tableBuildingsBuildingsCREATE TABLE Buildings (BuildingID INTEGER PRIMARY KEY AUTOINCREMENT, BuildingTypeID INTEGER NOT NULL, Team INTEGER NOT NULL, FOREIGN KEY(BuildingTypeID) REFERENCES BuildingTypes(BuildingTypeID))�N''�[tableBuildingTypesBuildingTypesCREATE TABLE BuildingTypes (BuildingTypeID INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(50) NOT NULL, TypeValue INTEGER NOT NULL, Description VARCHAR(100) NOT NULL)P++Ytablesqlite_sequencesqlite_sequenceCREATE TABLE sqlite_sequence(name,seq)��otableAiPathsAiPathsCREATE TABLE AiPaths (PathId INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(50) NOT NULL, Vectors TEXT NOT NULL)�!!�	tableAStarNodesAStarNodesCREATE TABLE AStarNodes (NodeId INTEGER NOT NULL, Position VARCHAR(50) NOT NULL, Cost INTEGER NOT NULL, Ne         		                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  � ��                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        BuildingsPlayers*      �                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    51%  d -49.6261 0 55.7546building_0_0OILPUMP   me="weapon1" disp_name="M4 Test1" semi="true" burst="false" auto="true" mag="9x19mm_15" rof="80" mesh="m4a1_1.mesh" overlay="Soldier/Target" accuracy="80" power="25" scale="1.0 1.0 1.0" range="100" />
<Magazine name="9x19mm_15" disp_name="9x19mm 15 round magazine" projectiles="9x19mm_JHP" capacity="150" mesh=""></Magazine>
<Projectile name="9x19mm_JHP" disp_name="9x19mm Jacketed Hollow Point" damage="25" penetrating="false" muzzle_velocity="350" speed="100" mesh="" pitch="90" roll="0" bbbullet="Bullet" bbflash="BulletSource"></Projectile>

<PagedTerrain name="Terrain" colormaptexturesize="128" detaildistance="240" iscolormap="false" lightmaptexturesize="1024" 
	mapsize="129" maxbatchsize="65" maxpixelerror="3" minbatchsize="33" pagedesitymapsize="1024" pagesize="40" pagex="2" 
	pagey="2" terrainfile="Page" worldsize="4000" resourcegroup="General" minx="-2" miny="-2" maxx="2" maxy="2" />

<!--
<PlaneTerrain normal="0 1 0" />
-->

<Caelum name="CaelumSky" timeday="1" timehour="12" timeminute="0" timemonth="                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              J  �  �i�J �                                                                              �b�tableBuil                                                                                 �!!�	tableAStarNodesAStarNodesCREATE TABLE AStarNodes (NodeId INTEGER NOT NULL, Position VARCHAR(50) NOT NULL, Cost INTEGER NOT NULL, Neighbors VARCHAR(50))��otableAiPathsAiPathsCREATE TABLE AiPaths (PathId INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(50) NOT NULL, Vectors TEXT NOT NULL)P++Ytablesqlite_sequencesqlite_sequenceCREATE TABLE sqlite_sequence(name,seq)  �''�[tableBuildingTypesBuildingTypesCREATE TABLE BuildingTypes (BuildingTypeID INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(50) NOT NULL, TypeValue INTEGER NOT NULL, Description VARCHAR(100) NOT NULL)   ��tableBuildingsBuildingsCREATE TABLE Buildings (BuildingID INTEGER PRIMARY KEY AUTOINCREMENT, BuildingTypeID INTEGER NOT NULL, Team INTEGER NOT NULL, FOREIGN KEY(BuildingTypeID) REFERENCES BuildingTypes(BuildingTypeID))    �  ��n^                                                                                                                                                                                                                                            �V##�stableGameObjectsGameObjectsCREATE TABLE GameObjects (GameObjectsID INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(50) NOT NULL, Type VARCHAR(50) NOT NULL, Orientation TEXT NOT NULL, Position TEXT NOT NULL)��tableJobTypesJobTypes
CREATE TABLE JobTypes (JobTypeID INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(50) NOT NULL, Description TEXT NOT NULL)�m))�tableLevelInventoryLevelInventoryCREATE TABLE LevelInventory (LevelInventoryID INTEGER PRIMARY KEY AUTOINCREMENT, ItemName VARCHAR(50) NOT NULL, ProfileName VARCHAR(50) NOT NULL, Orientation TEXT NOT NULL, Position TEXT NOT NULL)�	//�mtablePhysicsStrategiesPhysicsStrategiesCREATE TABLE PhysicsStrategies (PhysicsID INTEGER PRIMARY KEY, Name VARCHAR(50) NOT NULL, Type INTEGER NOT NULL)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               � �                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      physicso�aD                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 U U])                                                                                                                                                                                                                                                                                                                                       �
++�AtablePlayerInventoryPlayerInventoryCREATE TABLE PlayerInventory (PlayerID INTEGER NOT NULL, PlayerInventoryID INTEGER PRIMARY KEY AUTOINCREMENT, IsCurrentItem BOOL DEFAULT 0, ProfileName TEXT NOT NULL, FOREIGN KEY(PlayerId) REFERENCES Players(PlayerId))�I!!�]tablePlayerJobsPlayerJobsCREATE TABLE PlayerJobs (JobTypeID INTEGER, PlayerId INTEGER, FOREIGN KEY(JobTypeID) REFERENCES JobTypes(JobTypeID), FOREIGN KEY(PlayerId) REFERENCES Players(PlayerId))�T##�otablePlayerPathsPlayerPathsCREATE TABLE PlayerPaths (PathId INTEGER NOT NULL, PlayerId INTEGER NOT NULL, FOREIGN KEY(PathId) REFERENCES AiPaths(PathId), FOREIGN KEY(PlayerId) REFERENCES Players(PlayerId))                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               � �8�������                                                                            f%1%%player_27_2712.9146 0 -88.7281?�33@   �player_27_27IDLE0 0 1ZOMBIE_SMALLd       �%G%%player_32_3213.8806 9.53674e-007 -65.9328?�33@   �player_32_32IDLE0 0 1ZOMBIE_SMALLd       f%1%%player_33_3313.1575 0 -57.4122?�33@   �player_33_33IDLE0 0 1ZOMBIE_SMALLd       f%1%%player_34_3431.9221 0 -136.245?�33@   �player_34_34IDLE0 0 1ZOMBIE_SMALLd       �%1%%player_35_3525.5651 0 -102.893?�33@   �player_35_35IDLE0 0 1ZOMBIE_SMALLd       � c%1%player_39_39-14.8833 0 5.26092?�33@   �player_39_39IDLE0 0 -1SOLDIERd   d& %1%%player_37_3720.7279 0 -74.2782?�33@   �player_37_37IDLE0 0 1ZOMBIE_SMALLd    d' %1%%player_38_3816.8577 0 -56.7816?�33@   �player_38_38IDLE0 0 1ZOMBIE_SMALLd    `( %1%player_39_39-14.8833 0 5.26092?�33@   �player_39_39IDLE0 0 -1SOLDIERd      � �                                                                                                                                                                                                                                                                                                                                                                                                                                      �M�qtablePlayersPlayersCREATE TABLE Players (PlayerID INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(50) NOT NULL, Position TEXT NOT NULL, CrawlSpeed REAL NOT NULL, SprintSpeed REAL NOT NULL, IsHumanPlayer BOOL NOT NULL DEFAULT 0, ViewRange REAL NOT NULL, DieingTime REAL NOT NULL, MovableText TEXT, CharacterState VARCHAR(50) NOT NULL, Direction TEXT NOT NULL, PlayerType TEXT NOT NULL, Health REAL NOT NULL, Team INTEGER NOT NULL, RunSpeed REAL NOT NULL DEFAULT 0, ReloadSpeed REAL NOT NULL DEFAULT 0, RifleMarksman REAL NOT NULL DEFAULT 0, PhysicalStrength REAL NOT NULL DEFAULT 0)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  �  �                                                                                                                            �c�M<SceneManager ambient="0.361333 0.361333 0.361333 3" fogcolor="0.5 0.5 0.5 1" fogdensity="100" fogend="5000" fogstart="1000" 
name="MySceneManager" skyboxactive="false" skyboxdistance="5000" skyboxmaterial="" scenemanagertype="OctreeSceneManager" 
fogmode="FOG_LINEAR"></SceneManager>
<Viewport color="0 0 0 1" compositor0enabled="true" compositor0name="" name="Viewport1" parent=""></Viewport>
<Camera name="Camera1" type="god" clipdistance="0.1 59994" default="true" fov="0.785398" lookat="0 0 0" orientation="0 0 1 0" parent="" position="0 150 200"></Camera>

<Weapon name="weapon1" disp_name="M4 Test1" semi="true" burst="false" auto="true" mag="9x19mm_15" rof="80" mesh="m4a1_1.mesh" overlay="Soldier/Target" accuracy="80" power="25" scale="1.0 1.0 1.0" range="100" />
<Magazine name="9x19mm_15" disp_name="9x19mm 15 round magazine" projectiles="9x19mm_JHP" capacity="150" me      e="1" name="" 
position="0 500 0" power="1000" range="5000" shadows="true" specular="1 1 1"></Light>

<BgSound filename="TitleThemeDemo_14.ogg" name="" loop="true" stream="true" gain="0"></BgSound>

<!--
<Hydrax name="HydraxWater" causticsend="10" causticspower="9" causticsscale="16" configfile="Hydrax.hdx" 
depthlimit="0" foammaxdistance="7.5e+007" foamscale="0.0075" foamstart="-0.1" foamtransparency="1" 
fullreflectiondistance="1e+011" globaltransparency="0" godraysexposure="0.76 0.76 0.76" godraysintensity="0.015" 
godraysintersections="false" godraysnumrays="100" godrayssize="0.03" godraysspeed="5" iscaelumitegrated="false" 
iscomponentscaustics="true" iscomponentsdepth="true" iscomponentsfoam="true" iscomponentsgodrays="true" 
iscomponentsreflections="true" iscomponentssmooth="true" iscomponentssun="true" iscomponentsunderwater="true" 
ispgmodulechoppywaves="true" ispgmoduleforcerecalculategeometry="false" ispgmodulesmooth="false" layers="0" 
modulename="ProjectedGridVertex" noisemodulename="Perlin"    h" overlay="Soldier/Target" accuracy="80" power="25" scale="1.0 1.0 1.0" range="100" />
<Magazine name="9x19mm_15" disp_name="9x19mm 15 round magazine" projectiles="9x19mm_JHP" capacity="150" mesh=""></Magazine>
<Projectile name="9x19mm_JHP" disp_name="9x19mm Jacketed Hollow Point" damage="100" penetrating="false" muzzle_velocity="350" speed="100" mesh="" pitch="90" roll="0" bbbullet="BulletStreak" bbflash="BulletSource"></Projectile>

<PagedTerrain name="Terrain" colormaptexturesize="128" detaildistance="240" iscolormap="false" lightmaptexturesize="1024" 
	mapsize="129" maxbatchsize="65" maxpixelerror="3" minbatchsize="33" pagedesitymapsize="1024" pagesize="40" pagex="1" 
	pagey="1" terrainfile="Page" worldsize="4000" resourcegroup="General" minx="0" miny="0" maxx="0" maxy="0" />

<!--
<PlaneTerrain normal="0 1 0" />
-->

<Caelum name="CaelumSky" timeday="1" timehour="12" timeminute="0" timemonth="1" timesec="0" timespeed="0" 
timeyear="2000" isclouds="true" layerofclouds="3452816845" fogdenmultiplier="4   294967294" ismanagefog="false" 
layer="0" issinglelightsource="false" issingleshadowsource="false" ismanageambientlight="true" 
minambientlight="0.1 0.1 0.3 1" moonambientmultipler="0.2 0.2 0.2 1" moonattmultipler="1" moonattdistance="100000" 
moonattlinearmultipler="0" moonquadmultipler="0" ismoonautodisable="true" ismooncastshadow="true" 
moondiffusemultipler="1 1 0.9 1" ismoonenabled="true" moonspecularmultipler="1 1 1 1" observerlatitude="45" 
observerlongitude="0" isstarsenabled="true" starsmag0pixelsize="16" starsmagscale="2.51189" starsmaxpixelsize="6" 
starsminpixelsize="4" sunambientmultipler="0.5 0.5 0.5 1" sunattmultipler="1" sundistance="100000" 
sunattlinearmultipler="0" sunquadmultipler="0" issunautodisable="true" issuncastshadow="true" suncolor="0 0 0" 
sundiffusemultipler="0 0 0 1" issunenabled="true" sunlightcolor="0 0 0" sunposition="-309.9 8734.08 -21656.1" 
sunspecularmultipler="0 0 0 1">
</Caelum>


<Light parentnode="" attenuation="0 1 0 0" diffuse="1 1 1" direction="0 -1 0" lighttyp   sh=""></Magazine>
<Projectile name="9x19mm_JHP" disp_name="9x19mm Jacketed Hollow Point" damage="100" penetrating="false" muzzle_velocity="350" speed="100" mesh="" pitch="90" roll="0" bbbullet="BulletStreak" bbflash="BulletSource"></Projectile>

<PagedTerrain name="Terrain" colormaptexturesize="128" detaildistance="240" iscolormap="false" lightmaptexturesize="1024" 
	mapsize="129" maxbatchsize="65" maxpixelerror="3" minbatchsize="33" pagedesitymapsize="1024" pagesize="40" pagex="1" 
	pagey="1" terrainfile="Page" worldsize="4000" resourcegroup="General" minx="0" miny="0" maxx="0" maxy="0" />

<!--
<PlaneTerrain normal="0 1 0" />
-->

<Caelum name="CaelumSky" timeday="1" timehour="12" timeminute="0" timemonth="1" timesec="0" timespeed="0" 
timeyear="2000" isclouds="true" layerofclouds="3452816845" fogdenmultiplier="4294967294" ismanagefog="false" 
layer="0" issinglelightsource="false" issingleshadowsource="false" ismanageambientlight="true" 
minambientlight="0.1 0.1 0.3 1" moonambientmultipler="0.2 0.2 0.2    1" moonattmultipler="1" moonattdistance="100000" 
moonattlinearmultipler="0" moonquadmultipler="0" ismoonautodisable="true" ismooncastshadow="true" 
moondiffusemultipler="1 1 0.9 1" ismoonenabled="true" moonspecularmultipler="1 1 1 1" observerlatitude="45" 
observerlongitude="0" isstarsenabled="true" starsmag0pixelsize="16" starsmagscale="2.51189" starsmaxpixelsize="6" 
starsminpixelsize="4" sunambientmultipler="0.5 0.5 0.5 1" sunattmultipler="1" sundistance="100000" 
sunattlinearmultipler="0" sunquadmultipler="0" issunautodisable="true" issuncastshadow="true" suncolor="0 0 0" 
sundiffusemultipler="0 0 0 1" issunenabled="true" sunlightcolor="0 0 0" sunposition="-309.9 8734.08 -21656.1" 
sunspecularmultipler="0 0 0 1">
</Caelum>


<Light parentnode="" attenuation="0 1 0 0" diffuse="1 1 1" direction="0 -1 0" lighttype="1" name="" 
position="0 500 0" power="1000" range="5000" shadows="true" specular="1 1 1"
attrang="1000" attconst="1.0" attlin="0" attquad="0" spotinner="40" spotoutter="40" spotfalloff="1.0"
   � �A�                                                                                                                                                                                                                                                                                                                                                                                                                                                    }##�AtableSpawnPointsSpawnPointsCREATE TABLE SpawnPoints (Id INTEGER, Position TEXT NOT NULL, Team INTEGER, CoolDown REAL)F!!YtableStaticDataStaticDataCREATE TABLE StaticData (XmlData TEXT)�t�7tableBuildingsBuildingsCREATE TABLE Buildings (BuildingID INTEGER PRIMARY KEY AUTOINCREMENT, 
						BuildingCategory INTEGER NOT NULL, 
						Team INTEGER NOT NULL,
						Health REAL NOT NULL,
						BuildingState INTEGER NOT NULL,
						Position TEXT NOT NULL, 
						Name VARCHAR(50) NOT NULL,
						BuildingType VARCHAR(50) NOT NULL,
						DataValue VARCHAR(50))   spotnearclip="0.0" visible="true" shadfardis="0" shadnearclipdis="-1" shadnfarclipdis="-1">
</Light>

<BgSound filename="TitleThemeDemo_14.ogg" name="" loop="true" stream="true" gain="0"></BgSound>

<!--
<Hydrax name="HydraxWater" causticsend="10" causticspower="9" causticsscale="16" configfile="Hydrax.hdx" 
depthlimit="0" foammaxdistance="7.5e+007" foamscale="0.0075" foamstart="-0.1" foamtransparency="1" 
fullreflectiondistance="1e+011" globaltransparency="0" godraysexposure="0.76 0.76 0.76" godraysintensity="0.015" 
godraysintersections="false" godraysnumrays="100" godrayssize="0.03" godraysspeed="5" iscaelumitegrated="false" 
iscomponentscaustics="true" iscomponentsdepth="true" iscomponentsfoam="true" iscomponentsgodrays="true" 
iscomponentsreflections="true" iscomponentssmooth="true" iscomponentssun="true" iscomponentsunderwater="true" 
ispgmodulechoppywaves="true" ispgmoduleforcerecalculategeometry="false" ispgmodulesmooth="false" layers="0" 
modulename="ProjectedGridVertex" noisemodulename="Perlin"     normaldistortion="0.075" perlinanimspeed="1.2" 
perlinfalloff="0.49" perlingpulod="0.5 50 150000" perlingpustrength="2" perlinoctaves="8" perlinscale="0.185" 
perlintimemulti="1.27" pgmodulechoppystrength="1" pgmodulecomplexity="100" pgmoduleelevation="5" 
pgmodulestrength="3" planeserror="9.5" position="-500 10 -500" rttqualitydepth="0" rttqualitydepthaip="0" 
rttqualitydepthreflection="0" rttqualitygpunormalmap="0" rttqualityreflection="0" rttqualityrefraction="0" 
shadermode="3452816845" smoothpower="9.98" sunarea="746.089" suncolour="0 0 0" 
sunposition="2997.92 7460.89 -16863.8" sunstrength="1.75" techniqueadd="" techniqueremove="" updatescript="" 
watercolour="0 0 0"></Hydrax>
-->

<BillBoard name="BulletStreak" type="0" poolsize="100" material="bullet_streak" width="1" height=".001" />
<BillBoard name="Bullet" type="0" poolsize="100" material="blue_bullet" width="1" height="1" />
<BillBoard name="BulletSource" type="0" poolsize="100" material="blue_bullet_source" width=1" height="1" ></BillBoard>

       
                     !   "   #    esh="m4a1_1.mesh" overlay="Soldier/Target" accuracy="80" power="25" scale="1.0 1.0 1.0" range="100" />
<Magazine name="9x19mm_15" disp_name="9x19mm 15 round magazine" projectiles="9x19mm_JHP" capacity="150" mesh=""></Magazine>
<Projectile name="9x19mm_JHP" disp_name="9x19mm Jacketed Hollow Point" damage="25" penetrating="false" muzzle_velocity="350" mesh="" pitch="90" roll="0" bbbullet="Bullet" bbflash="BulletSource"></Projectile>

<Weapon name="weapon2" disp_name="M4 Test2" semi="true" burst="false" auto="true" mag="9x19mm_15" rof="80" mesh="m4a1_1.mesh" overlay="Soldier/Target" accuracy="80" power="25" scale="1.0 1.0 1.0" range="100" />
<Magazine name="9x19mm_15" disp_name="9x19mm 15 round magazine" projectiles="9x19mm_JHP" capacity="150" mesh=""></Magazine>
<Projectile name="9x19mm_JHP" disp_name="9x19mm Jacketed Hollow Point" damage="100" penetrating="false" muzzle_velocity="350" mesh="" pitch="90" roll="0" bbbullet="Bullet" bbflash="BulletSource"></Projecti    normaldistortion="0.075" perlinanimspeed="1.2" 
perlinfalloff="0.49" perlingpulod="0.5 50 150000" perlingpustrength="2" perlinoctaves="8" perlinscale="0.185" 
perlintimemulti="1.27" pgmodulechoppystrength="1" pgmodulecomplexity="100" pgmoduleelevation="5" 
pgmodulestrength="3" planeserror="9.5" position="-500 10 -500" rttqualitydepth="0" rttqualitydepthaip="0" 
rttqualitydepthreflection="0" rttqualitygpunormalmap="0" rttqualityreflection="0" rttqualityrefraction="0" 
shadermode="3452816845" smoothpower="9.98" sunarea="746.089" suncolour="0 0 0" 
sunposition="2997.92 7460.89 -16863.8" sunstrength="1.75" techniqueadd="" techniqueremove="" updatescript="" 
watercolour="0 0 0"></Hydrax>
-->

<BillBoard name="BulletStreak" type="0" poolsize="100" material="bullet_streak" width="1" height=".001" />
<BillBoard name="Bullet" type="0" poolsize="100" material="blue_bullet" width="1" height="1" />
<BillBoard name="BulletSource" type="0" poolsize="100" material="blue_bullet_source" width=1" height="1" ></BillBoard>

    lighttype="1" name="" 
position="0 500 0" power="1000" range="5000" shadows="true" specular="1 1 1"></Light>

<BgSound filename="TitleThemeDemo_14.ogg" name="" loop="true" stream="true" gain="0"></BgSound>

<Hydrax name="HydraxWater" causticsend="10" causticspower="9" causticsscale="16" configfile="Hydrax.hdx" 
depthlimit="0" foammaxdistance="7.5e+007" foamscale="0.0075" foamstart="-0.1" foamtransparency="1" 
fullreflectiondistance="1e+011" globaltransparency="0" godraysexposure="0.76 0.76 0.76" godraysintensity="0.015" 
godraysintersections="false" godraysnumrays="100" godrayssize="0.03" godraysspeed="5" iscaelumitegrated="false" 
iscomponentscaustics="true" iscomponentsdepth="true" iscomponentsfoam="true" iscomponentsgodrays="true" 
iscomponentsreflections="true" iscomponentssmooth="true" iscomponentssun="true" iscomponentsunderwater="true" 
ispgmodulechoppywaves="true" ispgmoduleforcerecalculategeometry="false" ispgmodulesmooth="false" layers="0" 
modulename="ProjectedGridVertex" noisemodulename="Perl    normaldistortion="0.075" perlinanimspeed="1.2" 
perlinfalloff="0.49" perlingpulod="0.5 50 150000" perlingpustrength="2" perlinoctaves="8" perlinscale="0.185" 
perlintimemulti="1.27" pgmodulechoppystrength="1" pgmodulecomplexity="100" pgmoduleelevation="5" 
pgmodulestrength="3" planeserror="9.5" position="-500 10 -500" rttqualitydepth="0" rttqualitydepthaip="0" 
rttqualitydepthreflection="0" rttqualitygpunormalmap="0" rttqualityreflection="0" rttqualityrefraction="0" 
shadermode="3452816845" smoothpower="9.98" sunarea="746.089" suncolour="0 0 0" 
sunposition="2997.92 7460.89 -16863.8" sunstrength="1.75" techniqueadd="" techniqueremove="" updatescript="" 
watercolour="0 0 0"></Hydrax>
-->

<BillBoard name="BulletStreak" type="0" poolsize="100" material="bullet_streak" width="1" height=".001" />
<BillBoard name="Bullet" type="0" poolsize="100" material="blue_bullet" width="1" height="1" />
<BillBoard name="BulletSource" type="0" poolsize="100" material="blue_bullet_source" width=1" height="1" ></BillBoard>

   "esh=""></Magazine>
<Projectile name="9x19mm_JHP" disp_name="9x19mm Jacketed Hollow Point" damage="100" penetrating="false" muzzle_velocity="350" speed="100" mesh="" pitch="90" roll="0" bbbullet="BulletStreak" bbflash="BulletSource"></Projectile>

<PagedTerrain name="Terrain" colormaptexturesize="128" detaildistance="240" iscolormap="false" lightmaptexturesize="1024" 
	mapsize="129" maxbatchsize="65" maxpixelerror="3" minbatchsize="33" pagedesitymapsize="1024" pagesize="40" pagex="1" 
	pagey="1" terrainfile="Page" worldsize="4000" resourcegroup="General" minx="0" miny="0" maxx="0" maxy="0" />

<!--
<PlaneTerrain normal="0 1 0" />
-->

<Caelum name="CaelumSky" timeday="1" timehour="12" timeminute="0" timemonth="1" timesec="0" timespeed="0" 
timeyear="2000" isclouds="true" layerofclouds="3452816845" fogdenmultiplier="4294967294" ismanagefog="false" 
layer="0" issinglelightsource="false" issingleshadowsource="false" ismanageambientlight="true" 
minambientlight="0.1 0.1 0.3 1" moonambientmultipler="0.2 0.2 0.2   # 1" moonattmultipler="1" moonattdistance="100000" 
moonattlinearmultipler="0" moonquadmultipler="0" ismoonautodisable="true" ismooncastshadow="true" 
moondiffusemultipler="1 1 0.9 1" ismoonenabled="true" moonspecularmultipler="1 1 1 1" observerlatitude="45" 
observerlongitude="0" isstarsenabled="true" starsmag0pixelsize="16" starsmagscale="2.51189" starsmaxpixelsize="6" 
starsminpixelsize="4" sunambientmultipler="0.5 0.5 0.5 1" sunattmultipler="1" sundistance="100000" 
sunattlinearmultipler="0" sunquadmultipler="0" issunautodisable="true" issuncastshadow="true" suncolor="0 0 0" 
sundiffusemultipler="0 0 0 1" issunenabled="true" sunlightcolor="0 0 0" sunposition="-309.9 8734.08 -21656.1" 
sunspecularmultipler="0 0 0 1">
</Caelum>


<Light parentnode="" attenuation="0 1 0 0" diffuse="1 1 1" direction="0 -1 0" lighttype="1" name="" 
position="0 500 0" power="1000" range="5000" shadows="true" specular="1 1 1"
attrang="1000" attconst="1.0" attlin="0" attquad="0"
spotinner="40" spotoutter="40"
spotfalloff="1.0"    
spotnearclip="0.0"
visible="true"
shadfardis="0"
shadnearclipdis="-1"
shadnfarclipdis="-1"
</Light>

<BgSound filename="TitleThemeDemo_14.ogg" name="" loop="true" stream="true" gain="0"></BgSound>

<!--
<Hydrax name="HydraxWater" causticsend="10" causticspower="9" causticsscale="16" configfile="Hydrax.hdx" 
depthlimit="0" foammaxdistance="7.5e+007" foamscale="0.0075" foamstart="-0.1" foamtransparency="1" 
fullreflectiondistance="1e+011" globaltransparency="0" godraysexposure="0.76 0.76 0.76" godraysintensity="0.015" 
godraysintersections="false" godraysnumrays="100" godrayssize="0.03" godraysspeed="5" iscaelumitegrated="false" 
iscomponentscaustics="true" iscomponentsdepth="true" iscomponentsfoam="true" iscomponentsgodrays="true" 
iscomponentsreflections="true" iscomponentssmooth="true" iscomponentssun="true" iscomponentsunderwater="true" 
ispgmodulechoppywaves="true" ispgmoduleforcerecalculategeometry="false" ispgmodulesmooth="false" layers="0" 
modulename="ProjectedGridVertex" noisemodulename="Perlin" 