#include "CGameObjectLampPost.h"
#include "CGameManager.h"
#include "CPhysicsManager.h"
#include "CPhysicsProfile.h"
#include "IPhysicsStrategy.h"

#include "OgreEntity.h"
#include "OgreSceneNode.h"
#include "OgreSceneManager.h"
#include "OgreMaterialManager.h"


using namespace Core;

namespace Core
{
namespace Plugin
{

CGameObjectLampPost::CGameObjectLampPost(const char* Name, Vector3& Pos) : CGameObject(Name)
{
	Node = CGameManager::Instance()->GetSceneManager()->getRootSceneNode()->createChildSceneNode(Name + String("_node"), Pos);
	Entity = CGameManager::Instance()->GetSceneManager()->createEntity(Name + String("_entity"), "LampPost.mesh");
	Entity->setQueryFlags(SQF_GAMEOBJECT);
	Node->attachObject(Entity);
	Entity->setMaterialName("orig_signfirelane_smoothing");
MaterialManager::getSingleton().getByName("orig_signfirelane_smoothing")->load();
	//Node->setScale(1.0f, 1.0f, 1.0f);

	// TODO: Customize physics profile here
	// ===================================
	PhysicsProfile = Physics::CPhysicsManager::Instance()->GetPhysicsProfile(Physics::CPhysicsManager::DEFAULT_LIGHT_CUBE);
	if(PhysicsProfile)
	{
		Physics::CPhysicsManager::Instance()->GetStrategy()->AddShape(this);
	}
	// ===================================

	GameObjectType = "LAMPPOST";
}

void CGameObjectLampPost::Update(const f32& elapsedTime)
{
}

CGameObjectLampPost::~CGameObjectLampPost()
{
	Physics::CPhysicsManager::Instance()->GetStrategy()->DestroyPhysicsBody(this);
}

CGameObjectLampPostFactory::CGameObjectLampPostFactory()
{
	GameObjectType = "LAMPPOST";
}

CGameObjectLampPostFactory::~CGameObjectLampPostFactory()
{
}

Core::CGameObject* CGameObjectLampPostFactory::CreateObject(const char* Name, Vector3& Pos)
{
	return new Plugin::CGameObjectLampPost(Name, Pos);
}
}
}
