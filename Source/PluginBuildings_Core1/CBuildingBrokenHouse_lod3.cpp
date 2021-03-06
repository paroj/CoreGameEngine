#include "CBuildingBrokenHouse_lod3.h"
#include "CGameManager.h"
#include "CGameObject.h"
#include "IPhysicsStrategy.h"
#include "CPhysicsManager.h"
#include "CPhysicsProfile.h"
#include "CPlayerSoundComponent.h"
#include "AnimationMapping.h"

#include "OgreEntity.h"
#include "OgreSceneNode.h"
#include "OgreSceneManager.h"
#include "OgreAnimationState.h"

using namespace Core;
using namespace Core::Plugin;

CBuildingBrokenHouse_lod3::CBuildingBrokenHouse_lod3(const char* Name, Physics::IPhysicsStrategy* PhysicsStrategy) : CBuilding(Name, PhysicsStrategy)
{
	m_MeshName = "BrokenHouse_lod3.mesh";
	auto sceneManager = CGameManager::Instance()->GetSceneManager();

	m_BuildingNode = sceneManager->getRootSceneNode()->createChildSceneNode(Name);
	m_BuildingEntity = sceneManager->createEntity(Name, m_MeshName);
	m_BuildingEntity->setQueryFlags(SQF_BUILDING);
	m_BuildingNode->attachObject(m_BuildingEntity);
	m_BuildingNode->setPosition(0, 0, 0);

	// ====== Set the building type ========
	m_BuildingType = "BROKENHOUSE_LOD3";
	// ===================================

	// ====== Set the category ===========
	m_BuildingCategory = EBC_SUPPLY;
	// ===================================

	// ====== Setup default physics ======
	if(PhysicsStrategy && m_BuildingNode && m_BuildingEntity)
	{
		auto profile = Physics::CPhysicsManager::Instance()->GetPhysicsProfile("DEFAULT_LIGHT_CUBE");
		if(profile)
		{
			auto boundingBox = m_BuildingEntity->getBoundingBox();
			auto height = boundingBox.getMaximum().y / 2;
			profile->SetPositionOffset(Vector3(0, height, 0));
			String objName = String(Name) + "_obj";
			auto gameObject = new CDummyGameObject(objName.c_str(), m_BuildingNode, m_BuildingEntity);
			if(gameObject)
			{
				m_GameObjects.push_back(gameObject);
				gameObject->PhysicsProfile = profile;
				PhysicsStrategy->AddShape(gameObject);
			}
		}
	}
	// ===================================

	PostInit();
}

CBuildingBrokenHouse_lod3::~CBuildingBrokenHouse_lod3()
{
}

void CBuildingBrokenHouse_lod3::SetupMapping()
{
}

void CBuildingBrokenHouse_lod3::Update(const f32& elapsedTime)
{
}

// CBuildingBrokenHouse_lod3Factory
CBuildingBrokenHouse_lod3Factory::CBuildingBrokenHouse_lod3Factory()
{
	BuildingType = "BROKENHOUSE_LOD3";
}

CBuildingBrokenHouse_lod3Factory::~CBuildingBrokenHouse_lod3Factory()
{
}

Core::CBuilding* CBuildingBrokenHouse_lod3Factory::CreateBuilding(const char* Name, Physics::IPhysicsStrategy* PhysicsStrategy)
{
	return new CBuildingBrokenHouse_lod3(Name, PhysicsStrategy);
}
