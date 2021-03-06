/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CMagazineProfile : CItemProfile
{
    private HandleRef swigCPtr;

    internal CMagazineProfile(IntPtr cPtr, bool cMemoryOwn)
        : base(testPINVOKE.CMagazineProfile_SWIGUpcast(cPtr), cMemoryOwn)
    {
        swigCPtr = new HandleRef(this, cPtr);
    }

    internal static HandleRef getCPtr(CMagazineProfile obj)
    {
        return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
    }

    ~CMagazineProfile()
    {
        Dispose();
    }

    public override void Dispose()
    {
        lock (this)
        {
            if (swigCPtr.Handle != IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    testPINVOKE.delete_CMagazineProfile(swigCPtr);
                }
                swigCPtr = new HandleRef(null, IntPtr.Zero);
            }
            GC.SuppressFinalize(this);
            base.Dispose();
        }
    }

    public CMagazineProfile()
        : this(testPINVOKE.new_CMagazineProfile(), true)
    {
    }

    public SWIGTYPE_p_u32 Capacity
    {
        set
        {
            testPINVOKE.CMagazineProfile_Capacity_set(swigCPtr, SWIGTYPE_p_u32.getCPtr(value));
            if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
        }
        get
        {
            SWIGTYPE_p_u32 ret = new SWIGTYPE_p_u32(testPINVOKE.CMagazineProfile_Capacity_get(swigCPtr), true);
            if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }
    }

    public CProjectileProfile ProjectileProfile
    {
        set
        {
            testPINVOKE.CMagazineProfile_ProjectileProfile_set(swigCPtr, CProjectileProfile.getCPtr(value));
        }
        get
        {
            IntPtr cPtr = testPINVOKE.CMagazineProfile_ProjectileProfile_get(swigCPtr);
            CProjectileProfile ret = (cPtr == IntPtr.Zero) ? null : new CProjectileProfile(cPtr, false);
            return ret;
        }
    }

}
