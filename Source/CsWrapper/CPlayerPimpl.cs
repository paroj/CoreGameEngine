/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CPlayerPimpl : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CPlayerPimpl(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CPlayerPimpl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CPlayerPimpl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_CPlayerPimpl(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public CPlayerPimpl(string LabelName, SWIGTYPE_p_Core__Physics__IPhysicsStrategy PhysicsStrategy) : this(testPINVOKE.new_CPlayerPimpl(LabelName, SWIGTYPE_p_Core__Physics__IPhysicsStrategy.getCPtr(PhysicsStrategy)), true) {
  }

  public void SetDirection(SWIGTYPE_p_Vector3 Direction) {
    testPINVOKE.CPlayerPimpl_SetDirection(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(Direction));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetLoSType(E_LOS_TYPE Type) {
    testPINVOKE.CPlayerPimpl_SetLoSType(swigCPtr, (int)Type);
  }

  public bool CanSee(SWIGTYPE_p_Vector3 Position) {
    bool ret = testPINVOKE.CPlayerPimpl_CanSee__SWIG_0(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(Position));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CanSee(CPlayer Player) {
    bool ret = testPINVOKE.CPlayerPimpl_CanSee__SWIG_1(swigCPtr, CPlayer.getCPtr(Player));
    return ret;
  }

  public CPlayer Duplicate(string PlayerType) {
    IntPtr cPtr = testPINVOKE.CPlayerPimpl_Duplicate(swigCPtr, PlayerType);
    CPlayer ret = (cPtr == IntPtr.Zero) ? null : new CPlayer(cPtr, false);
    return ret;
  }

  public void PostInit(CPlayer Player) {
    testPINVOKE.CPlayerPimpl_PostInit(swigCPtr, CPlayer.getCPtr(Player));
  }

  public void CheckForObjects() {
    testPINVOKE.CPlayerPimpl_CheckForObjects(swigCPtr);
  }

  public void TextLabelSetup() {
    testPINVOKE.CPlayerPimpl_TextLabelSetup(swigCPtr);
  }

  public void AddItem(CInventoryItem Item) {
    testPINVOKE.CPlayerPimpl_AddItem(swigCPtr, CInventoryItem.getCPtr(Item));
  }

  public void RemoveItem(CInventoryItem Item) {
    testPINVOKE.CPlayerPimpl_RemoveItem(swigCPtr, CInventoryItem.getCPtr(Item));
  }

  public void DropAllItems() {
    testPINVOKE.CPlayerPimpl_DropAllItems(swigCPtr);
  }

  public void RemoveAllItems() {
    testPINVOKE.CPlayerPimpl_RemoveAllItems(swigCPtr);
  }

  public void UseItem(CPlayer Player, CInventoryItem Item) {
    testPINVOKE.CPlayerPimpl_UseItem__SWIG_0(swigCPtr, CPlayer.getCPtr(Player), CInventoryItem.getCPtr(Item));
  }

  public void UseItem(CGameObject GameObject, CInventoryItem Item) {
    testPINVOKE.CPlayerPimpl_UseItem__SWIG_1(swigCPtr, CGameObject.getCPtr(GameObject), CInventoryItem.getCPtr(Item));
  }

  public void UseItem(CGameObject GameObject) {
    testPINVOKE.CPlayerPimpl_UseItem__SWIG_2(swigCPtr, CGameObject.getCPtr(GameObject));
  }

  public void OnPickupItem() {
    testPINVOKE.CPlayerPimpl_OnPickupItem(swigCPtr);
  }

  public void OnKill(CPlayer PlayerKilled, CProjectile Projectile) {
    testPINVOKE.CPlayerPimpl_OnKill__SWIG_0(swigCPtr, CPlayer.getCPtr(PlayerKilled), CProjectile.getCPtr(Projectile));
  }

  public void OnKill(CPlayer PlayerKilled, CInventoryItem InventoryItem) {
    testPINVOKE.CPlayerPimpl_OnKill__SWIG_1(swigCPtr, CPlayer.getCPtr(PlayerKilled), CInventoryItem.getCPtr(InventoryItem));
  }

  public void OnShotFired() {
    testPINVOKE.CPlayerPimpl_OnShotFired(swigCPtr);
  }

  public void OnHit(CProjectile Projectile, SWIGTYPE_p_Vector3 Direction) {
    testPINVOKE.CPlayerPimpl_OnHit__SWIG_0(swigCPtr, CProjectile.getCPtr(Projectile), SWIGTYPE_p_Vector3.getCPtr(Direction));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void OnHit(CInventoryItem InventoryItem, CPlayer Owner, SWIGTYPE_p_Vector3 Direction) {
    testPINVOKE.CPlayerPimpl_OnHit__SWIG_1(swigCPtr, CInventoryItem.getCPtr(InventoryItem), CPlayer.getCPtr(Owner), SWIGTYPE_p_Vector3.getCPtr(Direction));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DebugLoS(bool Show) {
    testPINVOKE.CPlayerPimpl_DebugLoS(swigCPtr, Show);
  }

  public void UpdateDefault(SWIGTYPE_p_f32 elapsedTime, SWIGTYPE_p_OIS__Keyboard Keyboard, SWIGTYPE_p_OIS__Mouse Mouse) {
    testPINVOKE.CPlayerPimpl_UpdateDefault(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime), SWIGTYPE_p_OIS__Keyboard.getCPtr(Keyboard), SWIGTYPE_p_OIS__Mouse.getCPtr(Mouse));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UpdateTextLabel(SWIGTYPE_p_f32 elapsedTime) {
    testPINVOKE.CPlayerPimpl_UpdateTextLabel(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UpdateMovement(SWIGTYPE_p_f32 elapsedTime, SWIGTYPE_p_OIS__Keyboard Keyboard, SWIGTYPE_p_OIS__Mouse Mouse) {
    testPINVOKE.CPlayerPimpl_UpdateMovement(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime), SWIGTYPE_p_OIS__Keyboard.getCPtr(Keyboard), SWIGTYPE_p_OIS__Mouse.getCPtr(Mouse));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UpdateAnimationState(SWIGTYPE_p_f32 elapsedTime, SWIGTYPE_p_OIS__Keyboard Keyboard) {
    testPINVOKE.CPlayerPimpl_UpdateAnimationState(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime), SWIGTYPE_p_OIS__Keyboard.getCPtr(Keyboard));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UpdateAnimation(SWIGTYPE_p_f32 elapsedTime) {
    testPINVOKE.CPlayerPimpl_UpdateAnimation(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UpdatePhysics(SWIGTYPE_p_f32 elapsedTime) {
    testPINVOKE.CPlayerPimpl_UpdatePhysics(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Vector3 GetPosition() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayerPimpl_GetPosition(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Vector3 GetHeadPosition() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayerPimpl_GetHeadPosition(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Quaternion GetHeadRotation() {
    SWIGTYPE_p_Quaternion ret = new SWIGTYPE_p_Quaternion(testPINVOKE.CPlayerPimpl_GetHeadRotation(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Vector3 GetBodyPosition() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayerPimpl_GetBodyPosition(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Quaternion GetBodyRotation() {
    SWIGTYPE_p_Quaternion ret = new SWIGTYPE_p_Quaternion(testPINVOKE.CPlayerPimpl_GetBodyRotation(swigCPtr), true);
    return ret;
  }

  public void SetYAxisFromTerrain_Paged(SWIGTYPE_p_f32 elapsedTime) {
    testPINVOKE.CPlayerPimpl_SetYAxisFromTerrain_Paged(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetYAxisFromTerrain_Height(SWIGTYPE_p_f32 elapsedTime) {
    testPINVOKE.CPlayerPimpl_SetYAxisFromTerrain_Height(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetCharacterState(E_PLAYER_STATE PlayerState) {
    testPINVOKE.CPlayerPimpl_SetCharacterState(swigCPtr, (int)PlayerState);
  }

  public void SetExactCharacterState(string State) {
    testPINVOKE.CPlayerPimpl_SetExactCharacterState(swigCPtr, State);
  }

  public void SetHumanPlayer(bool isPlayer) {
    testPINVOKE.CPlayerPimpl_SetHumanPlayer(swigCPtr, isPlayer);
  }

  public void SetPlayerPosition(SWIGTYPE_p_Vector3 Position) {
    testPINVOKE.CPlayerPimpl_SetPlayerPosition__SWIG_0(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(Position));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPlayerPosition(SWIGTYPE_p_f32 x, SWIGTYPE_p_f32 y, SWIGTYPE_p_f32 z) {
    testPINVOKE.CPlayerPimpl_SetPlayerPosition__SWIG_1(swigCPtr, SWIGTYPE_p_f32.getCPtr(x), SWIGTYPE_p_f32.getCPtr(y), SWIGTYPE_p_f32.getCPtr(z));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetVisible(bool Visible) {
    testPINVOKE.CPlayerPimpl_SetVisible(swigCPtr, Visible);
  }

  public string GetMovableText() {
    string ret = testPINVOKE.CPlayerPimpl_GetMovableText(swigCPtr);
    return ret;
  }

  public void SetPlayerState(E_PLAYER_STATE State) {
    testPINVOKE.CPlayerPimpl_SetPlayerState(swigCPtr, (int)State);
  }

  public SWIGTYPE_p_Vector3 GetEyePosition() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayerPimpl_GetEyePosition(swigCPtr), true);
    return ret;
  }

  public void SetTextLabelEnabled(bool Enabled) {
    testPINVOKE.CPlayerPimpl_SetTextLabelEnabled(swigCPtr, Enabled);
  }

  public void SetPlayerTeam(E_PLAYER_TEAM Team) {
    testPINVOKE.CPlayerPimpl_SetPlayerTeam(swigCPtr, (int)Team);
  }

  public void SetTextLabelCaption(string Text) {
    testPINVOKE.CPlayerPimpl_SetTextLabelCaption(swigCPtr, Text);
  }

  public CPlayer m_Player {
    set {
      testPINVOKE.CPlayerPimpl_m_Player_set(swigCPtr, CPlayer.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_Player_get(swigCPtr);
      CPlayer ret = (cPtr == IntPtr.Zero) ? null : new CPlayer(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_String Name {
    set {
      testPINVOKE.CPlayerPimpl_Name_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.CPlayerPimpl_Name_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_String m_MeshName {
    set {
      testPINVOKE.CPlayerPimpl_m_MeshName_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.CPlayerPimpl_m_MeshName_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_WalkSpeed {
    set {
      testPINVOKE.CPlayerPimpl_m_WalkSpeed_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_WalkSpeed_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_RunSpeed {
    set {
      testPINVOKE.CPlayerPimpl_m_RunSpeed_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_RunSpeed_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_SprintSpeed {
    set {
      testPINVOKE.CPlayerPimpl_m_SprintSpeed_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_SprintSpeed_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_CrawlSpeed {
    set {
      testPINVOKE.CPlayerPimpl_m_CrawlSpeed_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_CrawlSpeed_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_ReloadSpeed {
    set {
      testPINVOKE.CPlayerPimpl_m_ReloadSpeed_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_ReloadSpeed_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_Health {
    set {
      testPINVOKE.CPlayerPimpl_m_Health_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_Health_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_PickupRadius {
    set {
      testPINVOKE.CPlayerPimpl_m_PickupRadius_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_PickupRadius_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_DestinationRadius {
    set {
      testPINVOKE.CPlayerPimpl_m_DestinationRadius_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_DestinationRadius_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_FallVelocity {
    set {
      testPINVOKE.CPlayerPimpl_m_FallVelocity_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_FallVelocity_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_DieingTime {
    set {
      testPINVOKE.CPlayerPimpl_m_DieingTime_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_DieingTime_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_ViewRange {
    set {
      testPINVOKE.CPlayerPimpl_m_ViewRange_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_ViewRange_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 m_AnimationSpeed {
    set {
      testPINVOKE.CPlayerPimpl_m_AnimationSpeed_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayerPimpl_m_AnimationSpeed_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_SceneNode m_SightNode {
    set {
      testPINVOKE.CPlayerPimpl_m_SightNode_set(swigCPtr, SWIGTYPE_p_SceneNode.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_SightNode_get(swigCPtr);
      SWIGTYPE_p_SceneNode ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_SceneNode(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Entity m_PlayerEntity {
    set {
      testPINVOKE.CPlayerPimpl_m_PlayerEntity_set(swigCPtr, SWIGTYPE_p_Entity.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_PlayerEntity_get(swigCPtr);
      SWIGTYPE_p_Entity ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Entity(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_SceneNode m_PlayerNode {
    set {
      testPINVOKE.CPlayerPimpl_m_PlayerNode_set(swigCPtr, SWIGTYPE_p_SceneNode.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_PlayerNode_get(swigCPtr);
      SWIGTYPE_p_SceneNode ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_SceneNode(cPtr, false);
      return ret;
    } 
  }

  public bool isKilled {
    set {
      testPINVOKE.CPlayerPimpl_isKilled_set(swigCPtr, value);
    } 
    get {
      bool ret = testPINVOKE.CPlayerPimpl_isKilled_get(swigCPtr);
      return ret;
    } 
  }

  public bool isVisible {
    set {
      testPINVOKE.CPlayerPimpl_isVisible_set(swigCPtr, value);
    } 
    get {
      bool ret = testPINVOKE.CPlayerPimpl_isVisible_get(swigCPtr);
      return ret;
    } 
  }

  public bool isMovableText {
    set {
      testPINVOKE.CPlayerPimpl_isMovableText_set(swigCPtr, value);
    } 
    get {
      bool ret = testPINVOKE.CPlayerPimpl_isMovableText_get(swigCPtr);
      return ret;
    } 
  }

  public bool isHumanPlayer {
    set {
      testPINVOKE.CPlayerPimpl_isHumanPlayer_set(swigCPtr, value);
    } 
    get {
      bool ret = testPINVOKE.CPlayerPimpl_isHumanPlayer_get(swigCPtr);
      return ret;
    } 
  }

  public bool isCharacterController {
    set {
      testPINVOKE.CPlayerPimpl_isCharacterController_set(swigCPtr, value);
    } 
    get {
      bool ret = testPINVOKE.CPlayerPimpl_isCharacterController_get(swigCPtr);
      return ret;
    } 
  }

  public bool isFpsView {
    set {
      testPINVOKE.CPlayerPimpl_isFpsView_set(swigCPtr, value);
    } 
    get {
      bool ret = testPINVOKE.CPlayerPimpl_isFpsView_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector3 m_Movement {
    set {
      testPINVOKE.CPlayerPimpl_m_Movement_set(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayerPimpl_m_Movement_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector3 m_Direction {
    set {
      testPINVOKE.CPlayerPimpl_m_Direction_set(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayerPimpl_m_Direction_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector3 m_CCSize {
    set {
      testPINVOKE.CPlayerPimpl_m_CCSize_set(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayerPimpl_m_CCSize_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public CInventoryItem m_CurrItem {
    set {
      testPINVOKE.CPlayerPimpl_m_CurrItem_set(swigCPtr, CInventoryItem.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_CurrItem_get(swigCPtr);
      CInventoryItem ret = (cPtr == IntPtr.Zero) ? null : new CInventoryItem(cPtr, false);
      return ret;
    } 
  }

  public CItemsManager m_ItemsManager {
    set {
      testPINVOKE.CPlayerPimpl_m_ItemsManager_set(swigCPtr, CItemsManager.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_ItemsManager_get(swigCPtr);
      CItemsManager ret = (cPtr == IntPtr.Zero) ? null : new CItemsManager(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_RaySceneQuery m_ObjectQuery {
    set {
      testPINVOKE.CPlayerPimpl_m_ObjectQuery_set(swigCPtr, SWIGTYPE_p_RaySceneQuery.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_ObjectQuery_get(swigCPtr);
      SWIGTYPE_p_RaySceneQuery ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_RaySceneQuery(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_RaySceneQuery m_PlayerQuery {
    set {
      testPINVOKE.CPlayerPimpl_m_PlayerQuery_set(swigCPtr, SWIGTYPE_p_RaySceneQuery.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_PlayerQuery_get(swigCPtr);
      SWIGTYPE_p_RaySceneQuery ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_RaySceneQuery(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_RaySceneQuery m_TerrainRaySceneQuery {
    set {
      testPINVOKE.CPlayerPimpl_m_TerrainRaySceneQuery_set(swigCPtr, SWIGTYPE_p_RaySceneQuery.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_TerrainRaySceneQuery_get(swigCPtr);
      SWIGTYPE_p_RaySceneQuery ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_RaySceneQuery(cPtr, false);
      return ret;
    } 
  }

  public E_PLAYER_TEAM m_PlayerTeam {
    set {
      testPINVOKE.CPlayerPimpl_m_PlayerTeam_set(swigCPtr, (int)value);
    } 
    get {
      E_PLAYER_TEAM ret = (E_PLAYER_TEAM)testPINVOKE.CPlayerPimpl_m_PlayerTeam_get(swigCPtr);
      return ret;
    } 
  }

  public string m_PlayerType {
    set {
      testPINVOKE.CPlayerPimpl_m_PlayerType_set(swigCPtr, value);
    } 
    get {
      string ret = testPINVOKE.CPlayerPimpl_m_PlayerType_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_ManualObject m_Lineofsight {
    set {
      testPINVOKE.CPlayerPimpl_m_Lineofsight_set(swigCPtr, SWIGTYPE_p_ManualObject.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_Lineofsight_get(swigCPtr);
      SWIGTYPE_p_ManualObject ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_ManualObject(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_String m_RootBoneName {
    set {
      testPINVOKE.CPlayerPimpl_m_RootBoneName_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.CPlayerPimpl_m_RootBoneName_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_String m_HeadBoneName {
    set {
      testPINVOKE.CPlayerPimpl_m_HeadBoneName_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.CPlayerPimpl_m_HeadBoneName_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_Core__AI__CFpsVehicle m_Target {
    set {
      testPINVOKE.CPlayerPimpl_m_Target_set(swigCPtr, SWIGTYPE_p_Core__AI__CFpsVehicle.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_Target_get(swigCPtr);
      SWIGTYPE_p_Core__AI__CFpsVehicle ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__AI__CFpsVehicle(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_VectorT_Vector3_t m_PathPoints {
    set {
      testPINVOKE.CPlayerPimpl_m_PathPoints_set(swigCPtr, SWIGTYPE_p_VectorT_Vector3_t.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_VectorT_Vector3_t ret = new SWIGTYPE_p_VectorT_Vector3_t(testPINVOKE.CPlayerPimpl_m_PathPoints_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public E_LOS_TYPE m_LosType {
    set {
      testPINVOKE.CPlayerPimpl_m_LosType_set(swigCPtr, (int)value);
    } 
    get {
      E_LOS_TYPE ret = (E_LOS_TYPE)testPINVOKE.CPlayerPimpl_m_LosType_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_Core__AI__CFpsVehicle m_AbstractVehicle {
    set {
      testPINVOKE.CPlayerPimpl_m_AbstractVehicle_set(swigCPtr, SWIGTYPE_p_Core__AI__CFpsVehicle.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_AbstractVehicle_get(swigCPtr);
      SWIGTYPE_p_Core__AI__CFpsVehicle ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__AI__CFpsVehicle(cPtr, false);
      return ret;
    } 
  }

  public CCharacterStateManager m_CharacterStateManager {
    set {
      testPINVOKE.CPlayerPimpl_m_CharacterStateManager_set(swigCPtr, CCharacterStateManager.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_CharacterStateManager_get(swigCPtr);
      CCharacterStateManager ret = (cPtr == IntPtr.Zero) ? null : new CCharacterStateManager(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Core__AI__IAiReactionComponent m_AiReactionComponent {
    set {
      testPINVOKE.CPlayerPimpl_m_AiReactionComponent_set(swigCPtr, SWIGTYPE_p_Core__AI__IAiReactionComponent.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_AiReactionComponent_get(swigCPtr);
      SWIGTYPE_p_Core__AI__IAiReactionComponent ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__AI__IAiReactionComponent(cPtr, false);
      return ret;
    } 
  }

  public CCharacterState m_CharacterState {
    set {
      testPINVOKE.CPlayerPimpl_m_CharacterState_set(swigCPtr, CCharacterState.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_CharacterState_get(swigCPtr);
      CCharacterState ret = (cPtr == IntPtr.Zero) ? null : new CCharacterState(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Core__ILineOfSightStrategy m_LineOfSightStrategy {
    set {
      testPINVOKE.CPlayerPimpl_m_LineOfSightStrategy_set(swigCPtr, SWIGTYPE_p_Core__ILineOfSightStrategy.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_LineOfSightStrategy_get(swigCPtr);
      SWIGTYPE_p_Core__ILineOfSightStrategy ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__ILineOfSightStrategy(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Core__Physics__IPhysicsStrategy m_PhysicsStrategy {
    set {
      testPINVOKE.CPlayerPimpl_m_PhysicsStrategy_set(swigCPtr, SWIGTYPE_p_Core__Physics__IPhysicsStrategy.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_PhysicsStrategy_get(swigCPtr);
      SWIGTYPE_p_Core__Physics__IPhysicsStrategy ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__Physics__IPhysicsStrategy(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Core__Physics__ICharacterController m_CharacterController {
    set {
      testPINVOKE.CPlayerPimpl_m_CharacterController_set(swigCPtr, SWIGTYPE_p_Core__Physics__ICharacterController.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_CharacterController_get(swigCPtr);
      SWIGTYPE_p_Core__Physics__ICharacterController ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__Physics__ICharacterController(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Core__Physics__IPhysicsRagdoll m_PhysicsRagdoll {
    set {
      testPINVOKE.CPlayerPimpl_m_PhysicsRagdoll_set(swigCPtr, SWIGTYPE_p_Core__Physics__IPhysicsRagdoll.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_PhysicsRagdoll_get(swigCPtr);
      SWIGTYPE_p_Core__Physics__IPhysicsRagdoll ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__Physics__IPhysicsRagdoll(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_AnimationState m_AnimationState {
    set {
      testPINVOKE.CPlayerPimpl_m_AnimationState_set(swigCPtr, SWIGTYPE_p_AnimationState.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_AnimationState_get(swigCPtr);
      SWIGTYPE_p_AnimationState ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_AnimationState(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_VectorT_Core__CInventoryItem_p_t m_Items {
    set {
      testPINVOKE.CPlayerPimpl_m_Items_set(swigCPtr, SWIGTYPE_p_VectorT_Core__CInventoryItem_p_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_Items_get(swigCPtr);
      SWIGTYPE_p_VectorT_Core__CInventoryItem_p_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_VectorT_Core__CInventoryItem_p_t(cPtr, false);
      return ret;
    } 
  }

  public CoreEntityObject m_Ceo {
    set {
      testPINVOKE.CPlayerPimpl_m_Ceo_set(swigCPtr, CoreEntityObject.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_Ceo_get(swigCPtr);
      CoreEntityObject ret = (cPtr == IntPtr.Zero) ? null : new CoreEntityObject(cPtr, false);
      return ret;
    } 
  }

  public CGameManager m_GameManager {
    set {
      testPINVOKE.CPlayerPimpl_m_GameManager_set(swigCPtr, CGameManager.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_GameManager_get(swigCPtr);
      CGameManager ret = (cPtr == IntPtr.Zero) ? null : new CGameManager(cPtr, false);
      return ret;
    } 
  }

  public CCameraManager m_CameraManager {
    set {
      testPINVOKE.CPlayerPimpl_m_CameraManager_set(swigCPtr, CCameraManager.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_CameraManager_get(swigCPtr);
      CCameraManager ret = (cPtr == IntPtr.Zero) ? null : new CCameraManager(cPtr, false);
      return ret;
    } 
  }

  public CGameObjectManager m_GameObjectManager {
    set {
      testPINVOKE.CPlayerPimpl_m_GameObjectManager_set(swigCPtr, CGameObjectManager.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_GameObjectManager_get(swigCPtr);
      CGameObjectManager ret = (cPtr == IntPtr.Zero) ? null : new CGameObjectManager(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Core__CEnvironmentObserver m_EnvironmentObserver {
    set {
      testPINVOKE.CPlayerPimpl_m_EnvironmentObserver_set(swigCPtr, SWIGTYPE_p_Core__CEnvironmentObserver.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_EnvironmentObserver_get(swigCPtr);
      SWIGTYPE_p_Core__CEnvironmentObserver ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__CEnvironmentObserver(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_MapT_Core__E_ANIM_STATE_Core__SoundToAnimation_p_t m_AnimationMaps {
    set {
      testPINVOKE.CPlayerPimpl_m_AnimationMaps_set(swigCPtr, SWIGTYPE_p_MapT_Core__E_ANIM_STATE_Core__SoundToAnimation_p_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_AnimationMaps_get(swigCPtr);
      SWIGTYPE_p_MapT_Core__E_ANIM_STATE_Core__SoundToAnimation_p_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_MapT_Core__E_ANIM_STATE_Core__SoundToAnimation_p_t(cPtr, false);
      return ret;
    } 
  }

  public MovableTextOverlay m_MovableTextOverlay {
    set {
      testPINVOKE.CPlayerPimpl_m_MovableTextOverlay_set(swigCPtr, MovableTextOverlay.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_MovableTextOverlay_get(swigCPtr);
      MovableTextOverlay ret = (cPtr == IntPtr.Zero) ? null : new MovableTextOverlay(cPtr, false);
      return ret;
    } 
  }

  public CPlayerSoundComponent m_PlayerSoundComponent {
    set {
      testPINVOKE.CPlayerPimpl_m_PlayerSoundComponent_set(swigCPtr, CPlayerSoundComponent.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_PlayerSoundComponent_get(swigCPtr);
      CPlayerSoundComponent ret = (cPtr == IntPtr.Zero) ? null : new CPlayerSoundComponent(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Core__CPlayerAttributesComponent m_AttributesComponent {
    set {
      testPINVOKE.CPlayerPimpl_m_AttributesComponent_set(swigCPtr, SWIGTYPE_p_Core__CPlayerAttributesComponent.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CPlayerPimpl_m_AttributesComponent_get(swigCPtr);
      SWIGTYPE_p_Core__CPlayerAttributesComponent ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__CPlayerAttributesComponent(cPtr, false);
      return ret;
    } 
  }

  public E_ANIM_STATE m_AnimState {
    set {
      testPINVOKE.CPlayerPimpl_m_AnimState_set(swigCPtr, (int)value);
    } 
    get {
      E_ANIM_STATE ret = (E_ANIM_STATE)testPINVOKE.CPlayerPimpl_m_AnimState_get(swigCPtr);
      return ret;
    } 
  }

  public E_ANIM_STATE m_CurrAnimState {
    set {
      testPINVOKE.CPlayerPimpl_m_CurrAnimState_set(swigCPtr, (int)value);
    } 
    get {
      E_ANIM_STATE ret = (E_ANIM_STATE)testPINVOKE.CPlayerPimpl_m_CurrAnimState_get(swigCPtr);
      return ret;
    } 
  }

  public E_PLAYER_STATE m_PlayerState {
    set {
      testPINVOKE.CPlayerPimpl_m_PlayerState_set(swigCPtr, (int)value);
    } 
    get {
      E_PLAYER_STATE ret = (E_PLAYER_STATE)testPINVOKE.CPlayerPimpl_m_PlayerState_get(swigCPtr);
      return ret;
    } 
  }

}
