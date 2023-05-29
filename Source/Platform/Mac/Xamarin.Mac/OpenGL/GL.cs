using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using AppKit;

namespace OpenGL;

public sealed class GL
{
	internal static class Core
	{
		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glAccum", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Accum(AccumOp op, float value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glActiveProgramEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ActiveProgramEXT(uint program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glActiveShaderProgram", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ActiveShaderProgram(uint pipeline, uint program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glActiveStencilFaceEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ActiveStencilFaceEXT(ExtStencilTwoSide face);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glActiveTexture", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ActiveTexture(TextureUnit texture);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glActiveTextureARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ActiveTextureARB(TextureUnit texture);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glActiveVaryingNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ActiveVaryingNV(uint program, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glAlphaFragmentOp1ATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void AlphaFragmentOp1ATI(AtiFragmentShader op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glAlphaFragmentOp2ATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void AlphaFragmentOp2ATI(AtiFragmentShader op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glAlphaFragmentOp3ATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void AlphaFragmentOp3ATI(AtiFragmentShader op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glAlphaFunc", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void AlphaFunc(AlphaFunction func, float @ref);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glApplyTextureEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ApplyTextureEXT(ExtLightTexture mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glAreProgramsResidentNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern bool AreProgramsResidentNV(int n, uint* programs, [Out] bool* residences);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glAreTexturesResident", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern bool AreTexturesResident(int n, uint* textures, [Out] bool* residences);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glAreTexturesResidentEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern bool AreTexturesResidentEXT(int n, uint* textures, [Out] bool* residences);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glArrayElement", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ArrayElement(int i);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glArrayElementEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ArrayElementEXT(int i);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glArrayObjectATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ArrayObjectATI(EnableCap array, int size, AtiVertexArrayObject type, int stride, uint buffer, uint offset);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glAsyncMarkerSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void AsyncMarkerSGIX(uint marker);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glAttachObjectARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void AttachObjectARB(uint containerObj, uint obj);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glAttachShader", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void AttachShader(uint program, uint shader);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBegin", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Begin(BeginMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginConditionalRender", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginConditionalRender(uint id, ConditionalRenderType mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginConditionalRenderNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginConditionalRenderNV(uint id, NvConditionalRender mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginFragmentShaderATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginFragmentShaderATI();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginOcclusionQueryNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginOcclusionQueryNV(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginPerfMonitorAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginPerfMonitorAMD(uint monitor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginQuery", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginQuery(QueryTarget target, uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginQueryARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginQueryARB(ArbOcclusionQuery target, uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginQueryIndexed", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginQueryIndexed(QueryTarget target, uint index, uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginTransformFeedback", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginTransformFeedback(BeginFeedbackMode primitiveMode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginTransformFeedbackEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginTransformFeedbackEXT(ExtTransformFeedback primitiveMode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginTransformFeedbackNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginTransformFeedbackNV(NvTransformFeedback primitiveMode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginVertexShaderEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginVertexShaderEXT();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBeginVideoCaptureNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BeginVideoCaptureNV(uint video_capture_slot);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindAttribLocation(uint program, uint index, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindAttribLocationARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindAttribLocationARB(uint programObj, uint index, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindBuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindBuffer(BufferTarget target, uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindBufferARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindBufferARB(BufferTargetArb target, uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindBufferBase", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindBufferBase(BufferTarget target, uint index, uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindBufferBaseEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindBufferBaseEXT(ExtTransformFeedback target, uint index, uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindBufferBaseNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindBufferBaseNV(NvTransformFeedback target, uint index, uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindBufferOffsetEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindBufferOffsetEXT(ExtTransformFeedback target, uint index, uint buffer, IntPtr offset);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindBufferOffsetNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindBufferOffsetNV(NvTransformFeedback target, uint index, uint buffer, IntPtr offset);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindBufferRange", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindBufferRange(BufferTarget target, uint index, uint buffer, IntPtr offset, IntPtr size);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindBufferRangeEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindBufferRangeEXT(ExtTransformFeedback target, uint index, uint buffer, IntPtr offset, IntPtr size);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindBufferRangeNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindBufferRangeNV(NvTransformFeedback target, uint index, uint buffer, IntPtr offset, IntPtr size);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindFragDataLocation", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindFragDataLocation(uint program, uint color, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindFragDataLocationEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindFragDataLocationEXT(uint program, uint color, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindFragDataLocationIndexed", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindFragmentShaderATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindFragmentShaderATI(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindFramebuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindFramebuffer(FramebufferTarget target, uint framebuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindFramebufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindFramebufferEXT(FramebufferTarget target, uint framebuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindImageTextureEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindImageTextureEXT(uint index, uint texture, int level, bool layered, int layer, ExtShaderImageLoadStore access, int format);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindLightParameterEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int BindLightParameterEXT(LightName light, LightParameter value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindMaterialParameterEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int BindMaterialParameterEXT(MaterialFace face, MaterialParameter value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindMultiTextureEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindMultiTextureEXT(TextureUnit texunit, TextureTarget target, uint texture);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindParameterEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int BindParameterEXT(ExtVertexShader value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindProgramARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindProgramARB(AssemblyProgramTargetArb target, uint program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindProgramNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindProgramNV(AssemblyProgramTargetArb target, uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindProgramPipeline", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindProgramPipeline(uint pipeline);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindRenderbuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindRenderbuffer(RenderbufferTarget target, uint renderbuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindRenderbufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindRenderbufferEXT(RenderbufferTarget target, uint renderbuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindSampler", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindSampler(uint unit, uint sampler);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindTexGenParameterEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int BindTexGenParameterEXT(TextureUnit unit, TextureCoordName coord, TextureGenParameter value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindTexture", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindTexture(TextureTarget target, uint texture);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindTextureEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindTextureEXT(TextureTarget target, uint texture);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindTextureUnitParameterEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int BindTextureUnitParameterEXT(TextureUnit unit, ExtVertexShader value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindTransformFeedback", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindTransformFeedback(TransformFeedbackTarget target, uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindTransformFeedbackNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindTransformFeedbackNV(NvTransformFeedback2 target, uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindVertexArray", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindVertexArray(uint array);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindVertexArrayAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindVertexArrayAPPLE(uint array);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindVertexShaderEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindVertexShaderEXT(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindVideoCaptureStreamBufferNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindVideoCaptureStreamBufferNV(uint video_capture_slot, uint stream, NvVideoCapture frame_region, IntPtr offset);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBindVideoCaptureStreamTextureNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BindVideoCaptureStreamTextureNV(uint video_capture_slot, uint stream, NvVideoCapture frame_region, NvVideoCapture target, uint texture);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBinormal3bEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Binormal3bEXT(sbyte bx, sbyte by, sbyte bz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBinormal3bvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Binormal3bvEXT(sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBinormal3dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Binormal3dEXT(double bx, double by, double bz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBinormal3dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Binormal3dvEXT(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBinormal3fEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Binormal3fEXT(float bx, float by, float bz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBinormal3fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Binormal3fvEXT(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBinormal3iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Binormal3iEXT(int bx, int by, int bz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBinormal3ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Binormal3ivEXT(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBinormal3sEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Binormal3sEXT(short bx, short by, short bz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBinormal3svEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Binormal3svEXT(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBinormalPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BinormalPointerEXT(NormalPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBitmap", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendColor", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendColor(float red, float green, float blue, float alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendColorEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendColorEXT(float red, float green, float blue, float alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendEquation", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendEquation(BlendEquationMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendEquationEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendEquationEXT(ExtBlendMinmax mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendEquationi", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendEquationi(uint buf, Version40 mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendEquationiARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendEquationiARB(uint buf, ArbDrawBuffersBlend mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendEquationIndexedAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendEquationIndexedAMD(uint buf, AmdDrawBuffersBlend mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendEquationSeparate(BlendEquationMode modeRGB, BlendEquationMode modeAlpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendEquationSeparateEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendEquationSeparateEXT(ExtBlendEquationSeparate modeRGB, ExtBlendEquationSeparate modeAlpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendEquationSeparatei", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendEquationSeparatei(uint buf, BlendEquationMode modeRGB, BlendEquationMode modeAlpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendEquationSeparateiARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendEquationSeparateiARB(uint buf, ArbDrawBuffersBlend modeRGB, ArbDrawBuffersBlend modeAlpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendEquationSeparateIndexedAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendEquationSeparateIndexedAMD(uint buf, AmdDrawBuffersBlend modeRGB, AmdDrawBuffersBlend modeAlpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendFunc", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendFunc(BlendingFactorSrc sfactor, BlendingFactorDest dfactor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendFunci", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendFunci(uint buf, Version40 src, Version40 dst);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendFunciARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendFunciARB(uint buf, ArbDrawBuffersBlend src, ArbDrawBuffersBlend dst);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendFuncIndexedAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendFuncIndexedAMD(uint buf, AmdDrawBuffersBlend src, AmdDrawBuffersBlend dst);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendFuncSeparate(BlendingFactorSrc sfactorRGB, BlendingFactorDest dfactorRGB, BlendingFactorSrc sfactorAlpha, BlendingFactorDest dfactorAlpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendFuncSeparateEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendFuncSeparateEXT(ExtBlendFuncSeparate sfactorRGB, ExtBlendFuncSeparate dfactorRGB, ExtBlendFuncSeparate sfactorAlpha, ExtBlendFuncSeparate dfactorAlpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendFuncSeparatei", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendFuncSeparatei(uint buf, Version40 srcRGB, Version40 dstRGB, Version40 srcAlpha, Version40 dstAlpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendFuncSeparateiARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendFuncSeparateiARB(uint buf, ArbDrawBuffersBlend srcRGB, ArbDrawBuffersBlend dstRGB, ArbDrawBuffersBlend srcAlpha, ArbDrawBuffersBlend dstAlpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendFuncSeparateIndexedAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendFuncSeparateIndexedAMD(uint buf, AmdDrawBuffersBlend srcRGB, AmdDrawBuffersBlend dstRGB, AmdDrawBuffersBlend srcAlpha, AmdDrawBuffersBlend dstAlpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlendFuncSeparateINGR", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlendFuncSeparateINGR(All sfactorRGB, All dfactorRGB, All sfactorAlpha, All dfactorAlpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlitFramebuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBlitFramebufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, ExtFramebufferBlit filter);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBufferAddressRangeNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BufferAddressRangeNV(NvVertexBufferUnifiedMemory pname, uint index, ulong address, IntPtr length);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBufferData", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BufferData(BufferTarget target, IntPtr size, IntPtr data, BufferUsageHint usage);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBufferDataARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BufferDataARB(BufferTargetArb target, IntPtr size, IntPtr data, BufferUsageArb usage);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBufferParameteriAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BufferParameteriAPPLE(BufferTarget target, BufferParameterApple pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBufferSubData", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BufferSubData(BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glBufferSubDataARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void BufferSubDataARB(BufferTargetArb target, IntPtr offset, IntPtr size, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCallList", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CallList(uint list);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCallLists", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CallLists(int n, ListNameType type, IntPtr lists);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCheckFramebufferStatus", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern FramebufferErrorCode CheckFramebufferStatus(FramebufferTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCheckFramebufferStatusEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern FramebufferErrorCode CheckFramebufferStatusEXT(FramebufferTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCheckNamedFramebufferStatusEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern ExtDirectStateAccess CheckNamedFramebufferStatusEXT(uint framebuffer, FramebufferTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClampColor", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClampColor(ClampColorTarget target, ClampColorMode clamp);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClampColorARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClampColorARB(ArbColorBufferFloat target, ArbColorBufferFloat clamp);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClear", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Clear(ClearBufferMask mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearAccum", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClearAccum(float red, float green, float blue, float alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearBufferfi", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClearBufferfi(ClearBuffer buffer, int drawbuffer, float depth, int stencil);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearBufferfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ClearBufferfv(ClearBuffer buffer, int drawbuffer, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearBufferiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ClearBufferiv(ClearBuffer buffer, int drawbuffer, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearBufferuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ClearBufferuiv(ClearBuffer buffer, int drawbuffer, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearColor", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClearColor(float red, float green, float blue, float alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearColorIiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClearColorIiEXT(int red, int green, int blue, int alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearColorIuiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClearColorIuiEXT(uint red, uint green, uint blue, uint alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearDepth", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClearDepth(double depth);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearDepthdNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClearDepthdNV(double depth);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearDepthf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClearDepthf(float d);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearIndex", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClearIndex(float c);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClearStencil", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClearStencil(int s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClientActiveTexture", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClientActiveTexture(TextureUnit texture);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClientActiveTextureARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClientActiveTextureARB(TextureUnit texture);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClientActiveVertexStreamATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClientActiveVertexStreamATI(AtiVertexStreams stream);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClientAttribDefaultEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ClientAttribDefaultEXT(ClientAttribMask mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClientWaitSync", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern ArbSync ClientWaitSync(IntPtr sync, uint flags, ulong timeout);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glClipPlane", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ClipPlane(ClipPlaneName plane, double* equation);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3b", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color3b(sbyte red, sbyte green, sbyte blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3bv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color3bv(sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color3d(double red, double green, double blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color3dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color3f(float red, float green, float blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color3fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color3fVertex3fSUN(float r, float g, float b, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color3fVertex3fvSUN(float* c, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3i", ExactSpelling = true)]
		internal static extern void Color3i(int red, int green, int blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color3iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color3s(short red, short green, short blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color3sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3ub", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color3ub(byte red, byte green, byte blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3ubv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color3ubv(byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color3ui(uint red, uint green, uint blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color3uiv(uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3us", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color3us(ushort red, ushort green, ushort blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor3usv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color3usv(ushort* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4b", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4bv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color4bv(sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color4d(double red, double green, double blue, double alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color4dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color4f(float red, float green, float blue, float alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color4fNormal3fVertex3fvSUN(float* c, float* n, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color4fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color4i(int red, int green, int blue, int alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color4iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color4s(short red, short green, short blue, short alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color4sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4ub", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color4ub(byte red, byte green, byte blue, byte alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4ubv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color4ubv(byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4ubVertex2fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4ubVertex2fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color4ubVertex2fvSUN(byte* c, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4ubVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4ubVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color4ubVertex3fvSUN(byte* c, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color4ui(uint red, uint green, uint blue, uint alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color4uiv(uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4us", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Color4us(ushort red, ushort green, ushort blue, ushort alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColor4usv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Color4usv(ushort* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorFormatNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorFormatNV(int size, NvVertexBufferUnifiedMemory type, int stride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorFragmentOp1ATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorFragmentOp1ATI(AtiFragmentShader op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorFragmentOp2ATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorFragmentOp2ATI(AtiFragmentShader op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorFragmentOp3ATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorFragmentOp3ATI(AtiFragmentShader op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorMask", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorMask(bool red, bool green, bool blue, bool alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorMaski", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorMaski(uint index, bool r, bool g, bool b, bool a);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorMaskIndexedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorMaskIndexedEXT(uint index, bool r, bool g, bool b, bool a);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorMaterial", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorMaterial(MaterialFace face, ColorMaterialParameter mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorP3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorP3ui(PackedPointerType type, uint color);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorP3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ColorP3uiv(PackedPointerType type, uint* color);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorP4ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorP4ui(PackedPointerType type, uint color);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorP4uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ColorP4uiv(PackedPointerType type, uint* color);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorPointer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorPointerEXT(int size, ColorPointerType type, int stride, int count, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorPointerListIBM", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorPointerListIBM(int size, ColorPointerType type, int stride, IntPtr pointer, int ptrstride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorPointervINTEL", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorPointervINTEL(int size, VertexPointerType type, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorSubTable", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorSubTable(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorSubTableEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorSubTableEXT(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorTable", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorTable(ColorTableTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, IntPtr table);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorTableEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorTableEXT(ColorTableTarget target, PixelInternalFormat internalFormat, int width, PixelFormat format, PixelType type, IntPtr table);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorTableParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ColorTableParameterfv(ColorTableTarget target, ColorTableParameterPName pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorTableParameterfvSGI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ColorTableParameterfvSGI(SgiColorTable target, SgiColorTable pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorTableParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ColorTableParameteriv(ColorTableTarget target, ColorTableParameterPName pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorTableParameterivSGI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ColorTableParameterivSGI(SgiColorTable target, SgiColorTable pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glColorTableSGI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ColorTableSGI(SgiColorTable target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, IntPtr table);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCombinerInputNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CombinerInputNV(NvRegisterCombiners stage, NvRegisterCombiners portion, NvRegisterCombiners variable, NvRegisterCombiners input, NvRegisterCombiners mapping, NvRegisterCombiners componentUsage);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCombinerOutputNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CombinerOutputNV(NvRegisterCombiners stage, NvRegisterCombiners portion, NvRegisterCombiners abOutput, NvRegisterCombiners cdOutput, NvRegisterCombiners sumOutput, NvRegisterCombiners scale, NvRegisterCombiners bias, bool abDotProduct, bool cdDotProduct, bool muxSum);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCombinerParameterfNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CombinerParameterfNV(NvRegisterCombiners pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCombinerParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void CombinerParameterfvNV(NvRegisterCombiners pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCombinerParameteriNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CombinerParameteriNV(NvRegisterCombiners pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCombinerParameterivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void CombinerParameterivNV(NvRegisterCombiners pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCombinerStageParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void CombinerStageParameterfvNV(NvRegisterCombiners2 stage, NvRegisterCombiners2 pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompileShader", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompileShader(uint shader);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompileShaderARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompileShaderARB(uint shaderObj);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompileShaderIncludeARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void CompileShaderIncludeARB(uint shader, int count, string[] path, int* length);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedMultiTexImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedMultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int border, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedMultiTexImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedMultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int height, int border, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedMultiTexImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedMultiTexImage3DEXT(TextureUnit texunit, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int height, int depth, int border, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedMultiTexSubImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedMultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedMultiTexSubImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedMultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedMultiTexSubImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedMultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexImage1D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexImage1D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexImage1DARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexImage1DARB(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexImage2DARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexImage2DARB(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexImage3D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexImage3D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexImage3DARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexImage3DARB(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexSubImage1D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexSubImage1DARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexSubImage1DARB(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexSubImage2DARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexSubImage2DARB(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexSubImage3D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTexSubImage3DARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTexSubImage3DARB(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTextureImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTextureImage1DEXT(uint texture, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int border, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTextureImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTextureImage2DEXT(uint texture, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int height, int border, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTextureImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTextureImage3DEXT(uint texture, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int height, int depth, int border, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTextureSubImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTextureSubImage1DEXT(uint texture, TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTextureSubImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTextureSubImage2DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCompressedTextureSubImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CompressedTextureSubImage3DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr bits);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionFilter1D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ConvolutionFilter1D(ConvolutionTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, IntPtr image);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionFilter1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ConvolutionFilter1DEXT(ExtConvolution target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, IntPtr image);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionFilter2D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ConvolutionFilter2D(ConvolutionTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr image);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionFilter2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ConvolutionFilter2DEXT(ExtConvolution target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr image);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionParameterf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ConvolutionParameterf(ConvolutionTarget target, ConvolutionParameter pname, float @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionParameterfEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ConvolutionParameterfEXT(ExtConvolution target, ExtConvolution pname, float @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ConvolutionParameterfv(ConvolutionTarget target, ConvolutionParameter pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ConvolutionParameterfvEXT(ExtConvolution target, ExtConvolution pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionParameteri", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ConvolutionParameteri(ConvolutionTarget target, ConvolutionParameter pname, int @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionParameteriEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ConvolutionParameteriEXT(ExtConvolution target, ExtConvolution pname, int @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ConvolutionParameteriv(ConvolutionTarget target, ConvolutionParameter pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glConvolutionParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ConvolutionParameterivEXT(ExtConvolution target, ExtConvolution pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyBufferSubData", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyBufferSubData(BufferTarget readTarget, BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyColorSubTable", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyColorSubTable(ColorTableTarget target, int start, int x, int y, int width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyColorSubTableEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyColorSubTableEXT(ColorTableTarget target, int start, int x, int y, int width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyColorTable", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyColorTable(ColorTableTarget target, PixelInternalFormat internalformat, int x, int y, int width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyColorTableSGI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyColorTableSGI(SgiColorTable target, PixelInternalFormat internalformat, int x, int y, int width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyConvolutionFilter1D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyConvolutionFilter1D(ConvolutionTarget target, PixelInternalFormat internalformat, int x, int y, int width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyConvolutionFilter1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyConvolutionFilter1DEXT(ExtConvolution target, PixelInternalFormat internalformat, int x, int y, int width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyConvolutionFilter2D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyConvolutionFilter2D(ConvolutionTarget target, PixelInternalFormat internalformat, int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyConvolutionFilter2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyConvolutionFilter2DEXT(ExtConvolution target, PixelInternalFormat internalformat, int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyImageSubDataNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyImageSubDataNV(uint srcName, NvCopyImage srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, NvCopyImage dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyMultiTexImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyMultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, ExtDirectStateAccess internalformat, int x, int y, int width, int border);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyMultiTexImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyMultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, ExtDirectStateAccess internalformat, int x, int y, int width, int height, int border);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyMultiTexSubImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyMultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int x, int y, int width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyMultiTexSubImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyMultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyMultiTexSubImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyMultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyPixels", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyPixels(int x, int y, int width, int height, PixelCopyType type);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTexImage1D(TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTexImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTexImage1DEXT(TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTexImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTexImage2DEXT(TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, int width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTexSubImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTexSubImage1DEXT(TextureTarget target, int level, int xoffset, int x, int y, int width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTexSubImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTexSubImage2DEXT(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTexSubImage3D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTexSubImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTexSubImage3DEXT(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTextureImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTextureImage1DEXT(uint texture, TextureTarget target, int level, ExtDirectStateAccess internalformat, int x, int y, int width, int border);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTextureImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTextureImage2DEXT(uint texture, TextureTarget target, int level, ExtDirectStateAccess internalformat, int x, int y, int width, int height, int border);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTextureSubImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTextureSubImage1DEXT(uint texture, TextureTarget target, int level, int xoffset, int x, int y, int width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTextureSubImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTextureSubImage2DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCopyTextureSubImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CopyTextureSubImage3DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCreateProgram", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int CreateProgram();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCreateProgramObjectARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int CreateProgramObjectARB();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCreateShader", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int CreateShader(ShaderType type);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCreateShaderObjectARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int CreateShaderObjectARB(ArbShaderObjects shaderType);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCreateShaderProgramEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int CreateShaderProgramEXT(ExtSeparateShaderObjects type, string @string);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCreateShaderProgramv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int CreateShaderProgramv(ShaderType type, int count, string[] strings);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCreateSyncFromCLeventARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr CreateSyncFromCLeventARB(IntPtr context, IntPtr @event, uint flags);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCullFace", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CullFace(CullFaceMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCullParameterdvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void CullParameterdvEXT(ExtCullVertex pname, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCullParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void CullParameterfvEXT(ExtCullVertex pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glCurrentPaletteMatrixARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void CurrentPaletteMatrixARB(int index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDebugMessageControlARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DebugMessageControlARB(ArbDebugOutput source, ArbDebugOutput type, ArbDebugOutput severity, int count, uint* ids, bool enabled);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDebugMessageEnableAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DebugMessageEnableAMD(AmdDebugOutput category, AmdDebugOutput severity, int count, uint* ids, bool enabled);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDebugMessageInsertAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DebugMessageInsertAMD(AmdDebugOutput category, AmdDebugOutput severity, uint id, int length, string buf);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDebugMessageInsertARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DebugMessageInsertARB(ArbDebugOutput source, ArbDebugOutput type, uint id, ArbDebugOutput severity, int length, string buf);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeformationMap3dSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeformationMap3dSGIX(SgixPolynomialFfd target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeformationMap3fSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeformationMap3fSGIX(SgixPolynomialFfd target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeformSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DeformSGIX(uint mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteAsyncMarkersSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DeleteAsyncMarkersSGIX(uint marker, int range);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteBuffers(int n, uint* buffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteBuffersARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteBuffersARB(int n, uint* buffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteFencesAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteFencesAPPLE(int n, uint* fences);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteFencesNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteFencesNV(int n, uint* fences);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteFragmentShaderATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DeleteFragmentShaderATI(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteFramebuffers", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteFramebuffers(int n, uint* framebuffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteFramebuffersEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteFramebuffersEXT(int n, uint* framebuffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteLists", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DeleteLists(uint list, int range);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteNamedStringARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DeleteNamedStringARB(int namelen, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteNamesAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteNamesAMD(AmdNameGenDelete identifier, uint num, uint* names);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteObjectARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DeleteObjectARB(uint obj);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteOcclusionQueriesNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteOcclusionQueriesNV(int n, uint* ids);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeletePerfMonitorsAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeletePerfMonitorsAMD(int n, [Out] uint* monitors);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteProgram", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DeleteProgram(uint program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteProgramPipelines", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteProgramPipelines(int n, uint* pipelines);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteProgramsARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteProgramsARB(int n, uint* programs);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteProgramsNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteProgramsNV(int n, uint* programs);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteQueries", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteQueries(int n, uint* ids);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteQueriesARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteQueriesARB(int n, uint* ids);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteRenderbuffers", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteRenderbuffers(int n, uint* renderbuffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteRenderbuffersEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteRenderbuffersEXT(int n, uint* renderbuffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteSamplers", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteSamplers(int count, uint* samplers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteShader", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DeleteShader(uint shader);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteSync", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DeleteSync(IntPtr sync);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteTextures", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteTextures(int n, uint* textures);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteTexturesEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteTexturesEXT(int n, uint* textures);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteTransformFeedbacks", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteTransformFeedbacks(int n, uint* ids);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteTransformFeedbacksNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteTransformFeedbacksNV(int n, uint* ids);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteVertexArrays", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteVertexArrays(int n, uint* arrays);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteVertexArraysAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DeleteVertexArraysAPPLE(int n, uint* arrays);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDeleteVertexShaderEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DeleteVertexShaderEXT(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDepthBoundsdNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DepthBoundsdNV(double zmin, double zmax);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDepthBoundsEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DepthBoundsEXT(double zmin, double zmax);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDepthFunc", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DepthFunc(DepthFunction func);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDepthMask", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DepthMask(bool flag);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDepthRange", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DepthRange(double near, double far);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDepthRangeArrayv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DepthRangeArrayv(uint first, int count, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDepthRangedNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DepthRangedNV(double zNear, double zFar);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDepthRangef", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DepthRangef(float n, float f);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDepthRangeIndexed", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DepthRangeIndexed(uint index, double n, double f);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDetachObjectARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DetachObjectARB(uint containerObj, uint attachedObj);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDetachShader", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DetachShader(uint program, uint shader);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDetailTexFuncSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DetailTexFuncSGIS(TextureTarget target, int n, float* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDisable", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Disable(EnableCap cap);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDisableClientState", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DisableClientState(ArrayCap array);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDisableClientStateIndexedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DisableClientStateIndexedEXT(EnableCap array, uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDisablei", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Disablei(IndexedEnableCap target, uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDisableIndexedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DisableIndexedEXT(IndexedEnableCap target, uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDisableVariantClientStateEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DisableVariantClientStateEXT(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDisableVertexAttribAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DisableVertexAttribAPPLE(uint index, AppleVertexProgramEvaluators pname);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DisableVertexAttribArray(uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDisableVertexAttribArrayARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DisableVertexAttribArrayARB(uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawArrays", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawArrays(BeginMode mode, int first, int count);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawArraysEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawArraysEXT(BeginMode mode, int first, int count);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawArraysIndirect", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawArraysIndirect(ArbDrawIndirect mode, IntPtr indirect);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawArraysInstanced", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawArraysInstanced(BeginMode mode, int first, int count, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawArraysInstancedARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawArraysInstancedARB(BeginMode mode, int first, int count, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawArraysInstancedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawArraysInstancedEXT(BeginMode mode, int start, int count, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawBuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawBuffer(DrawBufferMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawBuffers", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DrawBuffers(int n, DrawBuffersEnum* bufs);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawBuffersARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DrawBuffersARB(int n, ArbDrawBuffers* bufs);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawBuffersATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void DrawBuffersATI(int n, AtiDrawBuffers* bufs);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawElementArrayAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawElementArrayAPPLE(BeginMode mode, int first, int count);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawElementArrayATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawElementArrayATI(BeginMode mode, int count);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawElements", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawElements(BeginMode mode, int count, DrawElementsType type, IntPtr indices);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawElementsBaseVertex", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawElementsBaseVertex(BeginMode mode, int count, DrawElementsType type, IntPtr indices, int basevertex);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawElementsIndirect", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawElementsIndirect(ArbDrawIndirect mode, ArbDrawIndirect type, IntPtr indirect);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawElementsInstanced", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawElementsInstanced(BeginMode mode, int count, DrawElementsType type, IntPtr indices, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawElementsInstancedARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawElementsInstancedARB(BeginMode mode, int count, DrawElementsType type, IntPtr indices, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawElementsInstancedBaseVertex", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawElementsInstancedBaseVertex(BeginMode mode, int count, DrawElementsType type, IntPtr indices, int primcount, int basevertex);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawElementsInstancedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawElementsInstancedEXT(BeginMode mode, int count, DrawElementsType type, IntPtr indices, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawMeshArraysSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawMeshArraysSUN(BeginMode mode, int first, int count, int width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawPixels", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawPixels(int width, int height, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawRangeElementArrayAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawRangeElementArrayAPPLE(BeginMode mode, uint start, uint end, int first, int count);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawRangeElementArrayATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawRangeElementArrayATI(BeginMode mode, uint start, uint end, int count);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawRangeElements", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawRangeElements(BeginMode mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawRangeElementsBaseVertex", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawRangeElementsBaseVertex(BeginMode mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices, int basevertex);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawRangeElementsEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawRangeElementsEXT(BeginMode mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawTransformFeedback", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawTransformFeedback(BeginMode mode, uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawTransformFeedbackNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawTransformFeedbackNV(NvTransformFeedback2 mode, uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glDrawTransformFeedbackStream", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void DrawTransformFeedbackStream(BeginMode mode, uint id, uint stream);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEdgeFlag", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EdgeFlag(bool flag);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEdgeFlagFormatNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EdgeFlagFormatNV(int stride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEdgeFlagPointer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EdgeFlagPointer(int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEdgeFlagPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void EdgeFlagPointerEXT(int stride, int count, bool* pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEdgeFlagPointerListIBM", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void EdgeFlagPointerListIBM(int stride, bool* pointer, int ptrstride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEdgeFlagv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void EdgeFlagv(bool* flag);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glElementPointerAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ElementPointerAPPLE(AppleElementArray type, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glElementPointerATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ElementPointerATI(AtiElementArray type, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEnable", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Enable(EnableCap cap);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEnableClientState", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EnableClientState(ArrayCap array);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEnableClientStateIndexedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EnableClientStateIndexedEXT(EnableCap array, uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEnablei", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Enablei(IndexedEnableCap target, uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEnableIndexedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EnableIndexedEXT(IndexedEnableCap target, uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEnableVariantClientStateEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EnableVariantClientStateEXT(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEnableVertexAttribAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EnableVertexAttribAPPLE(uint index, AppleVertexProgramEvaluators pname);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EnableVertexAttribArray(uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEnableVertexAttribArrayARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EnableVertexAttribArrayARB(uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEnd", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void End();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndConditionalRender", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndConditionalRender();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndConditionalRenderNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndConditionalRenderNV();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndFragmentShaderATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndFragmentShaderATI();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndList", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndList();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndOcclusionQueryNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndOcclusionQueryNV();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndPerfMonitorAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndPerfMonitorAMD(uint monitor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndQuery", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndQuery(QueryTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndQueryARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndQueryARB(ArbOcclusionQuery target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndQueryIndexed", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndQueryIndexed(QueryTarget target, uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndTransformFeedback", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndTransformFeedback();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndTransformFeedbackEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndTransformFeedbackEXT();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndTransformFeedbackNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndTransformFeedbackNV();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndVertexShaderEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndVertexShaderEXT();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEndVideoCaptureNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EndVideoCaptureNV(uint video_capture_slot);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalCoord1d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EvalCoord1d(double u);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalCoord1dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void EvalCoord1dv(double* u);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalCoord1f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EvalCoord1f(float u);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalCoord1fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void EvalCoord1fv(float* u);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalCoord2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EvalCoord2d(double u, double v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalCoord2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void EvalCoord2dv(double* u);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalCoord2f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EvalCoord2f(float u, float v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalCoord2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void EvalCoord2fv(float* u);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalMapsNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EvalMapsNV(NvEvaluators target, NvEvaluators mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalMesh1", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EvalMesh1(MeshMode1 mode, int i1, int i2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalMesh2", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EvalMesh2(MeshMode2 mode, int i1, int i2, int j1, int j2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalPoint1", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EvalPoint1(int i);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glEvalPoint2", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void EvalPoint2(int i, int j);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glExecuteProgramNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ExecuteProgramNV(AssemblyProgramTargetArb target, uint id, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glExtractComponentEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ExtractComponentEXT(uint res, uint src, uint num);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFeedbackBuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FeedbackBuffer(int size, FeedbackType type, [Out] float* buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFenceSync", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr FenceSync(ArbSync condition, uint flags);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFinalCombinerInputNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FinalCombinerInputNV(NvRegisterCombiners variable, NvRegisterCombiners input, NvRegisterCombiners mapping, NvRegisterCombiners componentUsage);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFinish", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Finish();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFinishAsyncSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern int FinishAsyncSGIX([Out] uint* markerp);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFinishFenceAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FinishFenceAPPLE(uint fence);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFinishFenceNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FinishFenceNV(uint fence);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFinishObjectAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FinishObjectAPPLE(AppleFence @object, int name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFinishTextureSUNX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FinishTextureSUNX();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFlush", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Flush();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFlushMappedBufferRange", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FlushMappedBufferRange(BufferTarget target, IntPtr offset, IntPtr length);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFlushMappedBufferRangeAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FlushMappedBufferRangeAPPLE(BufferTarget target, IntPtr offset, IntPtr size);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFlushMappedNamedBufferRangeEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FlushMappedNamedBufferRangeEXT(uint buffer, IntPtr offset, IntPtr length);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFlushPixelDataRangeNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FlushPixelDataRangeNV(NvPixelDataRange target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFlushRasterSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FlushRasterSGIX();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFlushVertexArrayRangeAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FlushVertexArrayRangeAPPLE(int length, [Out] IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFlushVertexArrayRangeNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FlushVertexArrayRangeNV();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoordd", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FogCoordd(double coord);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoorddEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FogCoorddEXT(double coord);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoorddv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FogCoorddv(double* coord);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoorddvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FogCoorddvEXT(double* coord);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoordf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FogCoordf(float coord);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoordfEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FogCoordfEXT(float coord);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoordFormatNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FogCoordFormatNV(NvVertexBufferUnifiedMemory type, int stride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoordfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FogCoordfv(float* coord);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoordfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FogCoordfvEXT(float* coord);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoordPointer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FogCoordPointer(FogPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoordPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FogCoordPointerEXT(ExtFogCoord type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogCoordPointerListIBM", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FogCoordPointerListIBM(IbmVertexArrayLists type, int stride, IntPtr pointer, int ptrstride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Fogf(FogParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogFuncSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FogFuncSGIS(int n, float* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Fogfv(FogParameter pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogi", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Fogi(FogParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFogiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Fogiv(FogParameter pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentColorMaterialSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FragmentColorMaterialSGIX(MaterialFace face, MaterialParameter mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentLightfSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FragmentLightfSGIX(SgixFragmentLighting light, SgixFragmentLighting pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentLightfvSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FragmentLightfvSGIX(SgixFragmentLighting light, SgixFragmentLighting pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentLightiSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FragmentLightiSGIX(SgixFragmentLighting light, SgixFragmentLighting pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentLightivSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FragmentLightivSGIX(SgixFragmentLighting light, SgixFragmentLighting pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentLightModelfSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FragmentLightModelfSGIX(SgixFragmentLighting pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentLightModelfvSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FragmentLightModelfvSGIX(SgixFragmentLighting pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentLightModeliSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FragmentLightModeliSGIX(SgixFragmentLighting pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentLightModelivSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FragmentLightModelivSGIX(SgixFragmentLighting pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentMaterialfSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FragmentMaterialfSGIX(MaterialFace face, MaterialParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentMaterialfvSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FragmentMaterialfvSGIX(MaterialFace face, MaterialParameter pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentMaterialiSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FragmentMaterialiSGIX(MaterialFace face, MaterialParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFragmentMaterialivSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FragmentMaterialivSGIX(MaterialFace face, MaterialParameter pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferDrawBufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferDrawBufferEXT(uint framebuffer, DrawBufferMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferDrawBuffersEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void FramebufferDrawBuffersEXT(uint framebuffer, int n, DrawBufferMode* bufs);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferReadBufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferReadBufferEXT(uint framebuffer, ReadBufferMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferRenderbuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferRenderbufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferRenderbufferEXT(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTexture", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTexture1D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTexture1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTexture1DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTexture2D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTexture2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTexture2DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTexture3D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTexture3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTexture3DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTextureARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTextureARB(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTextureEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTextureEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTextureFaceARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTextureFaceARB(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, TextureTarget face);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTextureFaceEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTextureFaceEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, TextureTarget face);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTextureLayer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTextureLayerARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTextureLayerARB(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFramebufferTextureLayerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FramebufferTextureLayerEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFrameTerminatorGREMEDY", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FrameTerminatorGREMEDY();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFrameZoomSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FrameZoomSGIX(int factor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFreeObjectBufferATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FreeObjectBufferATI(uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFrontFace", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void FrontFace(FrontFaceDirection mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glFrustum", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Frustum(double left, double right, double bottom, double top, double zNear, double zFar);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenAsyncMarkersSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GenAsyncMarkersSGIX(int range);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenBuffers", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenBuffers(int n, [Out] uint* buffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenBuffersARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenBuffersARB(int n, [Out] uint* buffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenerateMipmap", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GenerateMipmap(GenerateMipmapTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenerateMipmapEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GenerateMipmapEXT(GenerateMipmapTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenerateMultiTexMipmapEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GenerateMultiTexMipmapEXT(TextureUnit texunit, TextureTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenerateTextureMipmapEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GenerateTextureMipmapEXT(uint texture, TextureTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenFencesAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenFencesAPPLE(int n, [Out] uint* fences);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenFencesNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenFencesNV(int n, [Out] uint* fences);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenFragmentShadersATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GenFragmentShadersATI(uint range);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenFramebuffers", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenFramebuffers(int n, [Out] uint* framebuffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenFramebuffersEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenFramebuffersEXT(int n, [Out] uint* framebuffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenLists", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GenLists(int range);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenNamesAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenNamesAMD(AmdNameGenDelete identifier, uint num, [Out] uint* names);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenOcclusionQueriesNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenOcclusionQueriesNV(int n, [Out] uint* ids);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenPerfMonitorsAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenPerfMonitorsAMD(int n, [Out] uint* monitors);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenProgramPipelines", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenProgramPipelines(int n, [Out] uint* pipelines);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenProgramsARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenProgramsARB(int n, [Out] uint* programs);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenProgramsNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenProgramsNV(int n, [Out] uint* programs);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenQueries", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenQueries(int n, [Out] uint* ids);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenQueriesARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenQueriesARB(int n, [Out] uint* ids);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenRenderbuffers", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenRenderbuffers(int n, [Out] uint* renderbuffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenRenderbuffersEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenRenderbuffersEXT(int n, [Out] uint* renderbuffers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenSamplers", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenSamplers(int count, [Out] uint* samplers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenSymbolsEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GenSymbolsEXT(ExtVertexShader datatype, ExtVertexShader storagetype, ExtVertexShader range, uint components);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenTextures", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenTextures(int n, [Out] uint* textures);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenTexturesEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenTexturesEXT(int n, [Out] uint* textures);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenTransformFeedbacks", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenTransformFeedbacks(int n, [Out] uint* ids);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenTransformFeedbacksNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenTransformFeedbacksNV(int n, [Out] uint* ids);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenVertexArrays", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenVertexArrays(int n, [Out] uint* arrays);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenVertexArraysAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GenVertexArraysAPPLE(int n, [Out] uint* arrays);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGenVertexShadersEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GenVertexShadersEXT(uint range);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveAttrib(uint program, uint index, int bufSize, [Out] int* length, [Out] int* size, [Out] ActiveAttribType* type, [Out] StringBuilder name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveAttribARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveAttribARB(uint programObj, uint index, int maxLength, [Out] int* length, [Out] int* size, [Out] ArbVertexShader* type, [Out] StringBuilder name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveSubroutineName", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveSubroutineName(uint program, ShaderType shadertype, uint index, int bufsize, [Out] int* length, [Out] StringBuilder name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveSubroutineUniformiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveSubroutineUniformiv(uint program, ShaderType shadertype, uint index, ActiveSubroutineUniformParameter pname, [Out] int* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveSubroutineUniformName", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveSubroutineUniformName(uint program, ShaderType shadertype, uint index, int bufsize, [Out] int* length, [Out] StringBuilder name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveUniform(uint program, uint index, int bufSize, [Out] int* length, [Out] int* size, [Out] ActiveUniformType* type, [Out] StringBuilder name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveUniformARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveUniformARB(uint programObj, uint index, int maxLength, [Out] int* length, [Out] int* size, [Out] ArbShaderObjects* type, [Out] StringBuilder name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveUniformBlockiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, ActiveUniformBlockParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveUniformBlockName", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, [Out] int* length, [Out] StringBuilder uniformBlockName);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveUniformName", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, [Out] int* length, [Out] StringBuilder uniformName);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveUniformsiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, ActiveUniformParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetActiveVaryingNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetActiveVaryingNV(uint program, uint index, int bufSize, [Out] int* length, [Out] int* size, [Out] NvTransformFeedback* type, [Out] StringBuilder name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetArrayObjectfvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetArrayObjectfvATI(EnableCap array, AtiVertexArrayObject pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetArrayObjectivATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetArrayObjectivATI(EnableCap array, AtiVertexArrayObject pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetAttachedObjectsARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetAttachedObjectsARB(uint containerObj, int maxCount, [Out] int* count, [Out] uint* obj);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetAttachedShaders(uint program, int maxCount, [Out] int* count, [Out] uint* obj);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetAttribLocation(uint program, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetAttribLocationARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetAttribLocationARB(uint programObj, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetBooleani_v", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetBooleani_v(GetIndexedPName target, uint index, [Out] bool* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetBooleanIndexedvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetBooleanIndexedvEXT(ExtDrawBuffers2 target, uint index, [Out] bool* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetBooleanv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetBooleanv(GetPName pname, [Out] bool* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetBufferParameteri64v", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetBufferParameteri64v(Version32 target, Version32 pname, [Out] long* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetBufferParameteriv(BufferTarget target, BufferParameterName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetBufferParameterivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetBufferParameterivARB(ArbVertexBufferObject target, BufferParameterNameArb pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetBufferParameterui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetBufferParameterui64vNV(NvShaderBufferLoad target, NvShaderBufferLoad pname, [Out] ulong* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetBufferPointerv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetBufferPointerv(BufferTarget target, BufferPointer pname, [Out] IntPtr @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetBufferPointervARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetBufferPointervARB(ArbVertexBufferObject target, BufferPointerNameArb pname, [Out] IntPtr @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetBufferSubData", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetBufferSubData(BufferTarget target, IntPtr offset, IntPtr size, [Out] IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetBufferSubDataARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetBufferSubDataARB(BufferTargetArb target, IntPtr offset, IntPtr size, [Out] IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetClipPlane", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetClipPlane(ClipPlaneName plane, [Out] double* equation);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetColorTable", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetColorTable(ColorTableTarget target, PixelFormat format, PixelType type, [Out] IntPtr table);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetColorTableEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetColorTableEXT(ColorTableTarget target, PixelFormat format, PixelType type, [Out] IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetColorTableParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetColorTableParameterfv(ColorTableTarget target, GetColorTableParameterPName pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetColorTableParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetColorTableParameterfvEXT(ColorTableTarget target, GetColorTableParameterPName pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetColorTableParameterfvSGI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetColorTableParameterfvSGI(SgiColorTable target, SgiColorTable pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetColorTableParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetColorTableParameteriv(ColorTableTarget target, GetColorTableParameterPName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetColorTableParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetColorTableParameterivEXT(ColorTableTarget target, GetColorTableParameterPName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetColorTableParameterivSGI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetColorTableParameterivSGI(SgiColorTable target, SgiColorTable pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetColorTableSGI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetColorTableSGI(SgiColorTable target, PixelFormat format, PixelType type, [Out] IntPtr table);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetCombinerInputParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetCombinerInputParameterfvNV(NvRegisterCombiners stage, NvRegisterCombiners portion, NvRegisterCombiners variable, NvRegisterCombiners pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetCombinerInputParameterivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetCombinerInputParameterivNV(NvRegisterCombiners stage, NvRegisterCombiners portion, NvRegisterCombiners variable, NvRegisterCombiners pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetCombinerOutputParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetCombinerOutputParameterfvNV(NvRegisterCombiners stage, NvRegisterCombiners portion, NvRegisterCombiners pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetCombinerOutputParameterivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetCombinerOutputParameterivNV(NvRegisterCombiners stage, NvRegisterCombiners portion, NvRegisterCombiners pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetCombinerStageParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetCombinerStageParameterfvNV(NvRegisterCombiners2 stage, NvRegisterCombiners2 pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetCompressedMultiTexImageEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetCompressedMultiTexImageEXT(TextureUnit texunit, TextureTarget target, int lod, [Out] IntPtr img);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetCompressedTexImage", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetCompressedTexImage(TextureTarget target, int level, [Out] IntPtr img);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetCompressedTexImageARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetCompressedTexImageARB(TextureTarget target, int level, [Out] IntPtr img);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetCompressedTextureImageEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetCompressedTextureImageEXT(uint texture, TextureTarget target, int lod, [Out] IntPtr img);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetConvolutionFilter", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, [Out] IntPtr image);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetConvolutionFilterEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetConvolutionFilterEXT(ExtConvolution target, PixelFormat format, PixelType type, [Out] IntPtr image);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetConvolutionParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetConvolutionParameterfv(ConvolutionTarget target, GetConvolutionParameterPName pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetConvolutionParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetConvolutionParameterfvEXT(ExtConvolution target, ExtConvolution pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetConvolutionParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetConvolutionParameteriv(ConvolutionTarget target, GetConvolutionParameterPName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetConvolutionParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetConvolutionParameterivEXT(ExtConvolution target, ExtConvolution pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetDebugMessageLogAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern int GetDebugMessageLogAMD(uint count, int bufsize, [Out] AmdDebugOutput* categories, [Out] uint* severities, [Out] uint* ids, [Out] int* lengths, [Out] StringBuilder message);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetDebugMessageLogARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern int GetDebugMessageLogARB(uint count, int bufsize, [Out] ArbDebugOutput* sources, [Out] ArbDebugOutput* types, [Out] uint* ids, [Out] ArbDebugOutput* severities, [Out] int* lengths, [Out] StringBuilder messageLog);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetDetailTexFuncSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetDetailTexFuncSGIS(TextureTarget target, [Out] float* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetDoublei_v", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetDoublei_v(GetIndexedPName target, uint index, [Out] double* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetDoubleIndexedvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetDoubleIndexedvEXT(ExtDirectStateAccess target, uint index, [Out] double* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetDoublev", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetDoublev(GetPName pname, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetError", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern ErrorCode GetError();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFenceivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFenceivNV(uint fence, NvFence pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFinalCombinerInputParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFinalCombinerInputParameterfvNV(NvRegisterCombiners variable, NvRegisterCombiners pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFinalCombinerInputParameterivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFinalCombinerInputParameterivNV(NvRegisterCombiners variable, NvRegisterCombiners pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFloati_v", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFloati_v(GetIndexedPName target, uint index, [Out] float* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFloatIndexedvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFloatIndexedvEXT(ExtDirectStateAccess target, uint index, [Out] float* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFloatv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFloatv(GetPName pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFogFuncSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFogFuncSGIS([Out] float* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFragDataIndex", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetFragDataIndex(uint program, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFragDataLocation", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetFragDataLocation(uint program, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFragDataLocationEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetFragDataLocationEXT(uint program, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFragmentLightfvSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFragmentLightfvSGIX(SgixFragmentLighting light, SgixFragmentLighting pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFragmentLightivSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFragmentLightivSGIX(SgixFragmentLighting light, SgixFragmentLighting pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFragmentMaterialfvSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFragmentMaterialfvSGIX(MaterialFace face, MaterialParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFragmentMaterialivSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFragmentMaterialivSGIX(MaterialFace face, MaterialParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFramebufferAttachmentParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferParameterName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFramebufferAttachmentParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFramebufferAttachmentParameterivEXT(FramebufferTarget target, FramebufferAttachment attachment, FramebufferParameterName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetFramebufferParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetFramebufferParameterivEXT(uint framebuffer, ExtDirectStateAccess pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetGraphicsResetStatusARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern ArbRobustness GetGraphicsResetStatusARB();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetHandleARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetHandleARB(ArbShaderObjects pname);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetHistogram", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetHistogram(HistogramTarget target, bool reset, PixelFormat format, PixelType type, [Out] IntPtr values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetHistogramEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetHistogramEXT(ExtHistogram target, bool reset, PixelFormat format, PixelType type, [Out] IntPtr values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetHistogramParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetHistogramParameterfv(HistogramTarget target, GetHistogramParameterPName pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetHistogramParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetHistogramParameterfvEXT(ExtHistogram target, ExtHistogram pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetHistogramParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetHistogramParameteriv(HistogramTarget target, GetHistogramParameterPName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetHistogramParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetHistogramParameterivEXT(ExtHistogram target, ExtHistogram pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetImageTransformParameterfvHP", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetImageTransformParameterfvHP(HpImageTransform target, HpImageTransform pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetImageTransformParameterivHP", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetImageTransformParameterivHP(HpImageTransform target, HpImageTransform pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetInfoLogARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetInfoLogARB(uint obj, int maxLength, [Out] int* length, [Out] StringBuilder infoLog);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetInstrumentsSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetInstrumentsSGIX();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetInteger64i_v", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetInteger64i_v(Version32 target, uint index, [Out] long* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetInteger64v", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetInteger64v(ArbSync pname, [Out] long* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetIntegeri_v", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetIntegeri_v(GetIndexedPName target, uint index, [Out] int* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetIntegerIndexedvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetIntegerIndexedvEXT(GetIndexedPName target, uint index, [Out] int* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetIntegerui64i_vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetIntegerui64i_vNV(NvVertexBufferUnifiedMemory value, uint index, [Out] ulong* result);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetIntegerui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetIntegerui64vNV(NvShaderBufferLoad value, [Out] ulong* result);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetIntegerv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetIntegerv(GetPName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetInvariantBooleanvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetInvariantBooleanvEXT(uint id, ExtVertexShader value, [Out] bool* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetInvariantFloatvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetInvariantFloatvEXT(uint id, ExtVertexShader value, [Out] float* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetInvariantIntegervEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetInvariantIntegervEXT(uint id, ExtVertexShader value, [Out] int* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetLightfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetLightfv(LightName light, LightParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetLightiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetLightiv(LightName light, LightParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetListParameterfvSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetListParameterfvSGIX(uint list, ListParameterName pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetListParameterivSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetListParameterivSGIX(uint list, ListParameterName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetLocalConstantBooleanvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetLocalConstantBooleanvEXT(uint id, ExtVertexShader value, [Out] bool* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetLocalConstantFloatvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetLocalConstantFloatvEXT(uint id, ExtVertexShader value, [Out] float* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetLocalConstantIntegervEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetLocalConstantIntegervEXT(uint id, ExtVertexShader value, [Out] int* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMapAttribParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMapAttribParameterfvNV(NvEvaluators target, uint index, NvEvaluators pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMapAttribParameterivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMapAttribParameterivNV(NvEvaluators target, uint index, NvEvaluators pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMapControlPointsNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetMapControlPointsNV(NvEvaluators target, uint index, NvEvaluators type, int ustride, int vstride, bool packed, [Out] IntPtr points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMapdv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMapdv(MapTarget target, GetMapQuery query, [Out] double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMapfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMapfv(MapTarget target, GetMapQuery query, [Out] float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMapiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMapiv(MapTarget target, GetMapQuery query, [Out] int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMapParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMapParameterfvNV(NvEvaluators target, NvEvaluators pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMapParameterivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMapParameterivNV(NvEvaluators target, NvEvaluators pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMaterialfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMaterialfv(MaterialFace face, MaterialParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMaterialiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMaterialiv(MaterialFace face, MaterialParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMinmax", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetMinmax(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, [Out] IntPtr values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMinmaxEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetMinmaxEXT(ExtHistogram target, bool reset, PixelFormat format, PixelType type, [Out] IntPtr values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMinmaxParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMinmaxParameterfv(MinmaxTarget target, GetMinmaxParameterPName pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMinmaxParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMinmaxParameterfvEXT(ExtHistogram target, ExtHistogram pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMinmaxParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMinmaxParameteriv(MinmaxTarget target, GetMinmaxParameterPName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMinmaxParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMinmaxParameterivEXT(ExtHistogram target, ExtHistogram pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultisamplefv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultisamplefv(GetMultisamplePName pname, uint index, [Out] float* val);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultisamplefvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultisamplefvNV(NvExplicitMultisample pname, uint index, [Out] float* val);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexEnvfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultiTexEnvfvEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexEnvivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultiTexEnvivEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexGendvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultiTexGendvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexGenfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultiTexGenfvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexGenivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultiTexGenivEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexImageEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetMultiTexImageEXT(TextureUnit texunit, TextureTarget target, int level, PixelFormat format, PixelType type, [Out] IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexLevelParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultiTexLevelParameterfvEXT(TextureUnit texunit, TextureTarget target, int level, GetTextureParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexLevelParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultiTexLevelParameterivEXT(TextureUnit texunit, TextureTarget target, int level, GetTextureParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultiTexParameterfvEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexParameterIivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultiTexParameterIivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexParameterIuivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultiTexParameterIuivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetMultiTexParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetMultiTexParameterivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedBufferParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetNamedBufferParameterivEXT(uint buffer, ExtDirectStateAccess pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedBufferParameterui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetNamedBufferParameterui64vNV(uint buffer, NvShaderBufferLoad pname, [Out] ulong* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedBufferPointervEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetNamedBufferPointervEXT(uint buffer, ExtDirectStateAccess pname, [Out] IntPtr @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedBufferSubDataEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetNamedBufferSubDataEXT(uint buffer, IntPtr offset, IntPtr size, [Out] IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetNamedFramebufferAttachmentParameterivEXT(uint framebuffer, FramebufferAttachment attachment, ExtDirectStateAccess pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedProgramivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetNamedProgramivEXT(uint program, ExtDirectStateAccess target, ExtDirectStateAccess pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedProgramLocalParameterdvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetNamedProgramLocalParameterdvEXT(uint program, ExtDirectStateAccess target, uint index, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedProgramLocalParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetNamedProgramLocalParameterfvEXT(uint program, ExtDirectStateAccess target, uint index, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedProgramLocalParameterIivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetNamedProgramLocalParameterIivEXT(uint program, ExtDirectStateAccess target, uint index, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedProgramLocalParameterIuivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetNamedProgramLocalParameterIuivEXT(uint program, ExtDirectStateAccess target, uint index, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedProgramStringEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetNamedProgramStringEXT(uint program, ExtDirectStateAccess target, ExtDirectStateAccess pname, [Out] IntPtr @string);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedRenderbufferParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetNamedRenderbufferParameterivEXT(uint renderbuffer, RenderbufferParameterName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedStringARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetNamedStringARB(int namelen, string name, int bufSize, [Out] int* stringlen, [Out] StringBuilder @string);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetNamedStringivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetNamedStringivARB(int namelen, string name, ArbShadingLanguageInclude pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnColorTableARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetnColorTableARB(ArbRobustness target, ArbRobustness format, ArbRobustness type, int bufSize, [Out] IntPtr table);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnCompressedTexImageARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetnCompressedTexImageARB(ArbRobustness target, int lod, int bufSize, [Out] IntPtr img);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnConvolutionFilterARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetnConvolutionFilterARB(ArbRobustness target, ArbRobustness format, ArbRobustness type, int bufSize, [Out] IntPtr image);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnHistogramARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetnHistogramARB(ArbRobustness target, bool reset, ArbRobustness format, ArbRobustness type, int bufSize, [Out] IntPtr values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnMapdvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetnMapdvARB(ArbRobustness target, ArbRobustness query, int bufSize, [Out] double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnMapfvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetnMapfvARB(ArbRobustness target, ArbRobustness query, int bufSize, [Out] float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnMapivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetnMapivARB(ArbRobustness target, ArbRobustness query, int bufSize, [Out] int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnMinmaxARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetnMinmaxARB(ArbRobustness target, bool reset, ArbRobustness format, ArbRobustness type, int bufSize, [Out] IntPtr values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnPixelMapfvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetnPixelMapfvARB(ArbRobustness map, int bufSize, [Out] float* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnPixelMapuivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetnPixelMapuivARB(ArbRobustness map, int bufSize, [Out] uint* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnPixelMapusvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetnPixelMapusvARB(ArbRobustness map, int bufSize, [Out] ushort* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnPolygonStippleARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetnPolygonStippleARB(int bufSize, [Out] byte* pattern);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnSeparableFilterARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetnSeparableFilterARB(ArbRobustness target, ArbRobustness format, ArbRobustness type, int rowBufSize, [Out] IntPtr row, int columnBufSize, [Out] IntPtr column, [Out] IntPtr span);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnTexImageARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetnTexImageARB(ArbRobustness target, int level, ArbRobustness format, ArbRobustness type, int bufSize, [Out] IntPtr img);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnUniformdvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetnUniformdvARB(uint program, int location, int bufSize, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnUniformfvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetnUniformfvARB(uint program, int location, int bufSize, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnUniformivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetnUniformivARB(uint program, int location, int bufSize, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetnUniformuivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetnUniformuivARB(uint program, int location, int bufSize, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetObjectBufferfvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetObjectBufferfvATI(uint buffer, AtiVertexArrayObject pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetObjectBufferivATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetObjectBufferivATI(uint buffer, AtiVertexArrayObject pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetObjectParameterfvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetObjectParameterfvARB(uint obj, ArbShaderObjects pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetObjectParameterivAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetObjectParameterivAPPLE(AppleObjectPurgeable objectType, uint name, AppleObjectPurgeable pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetObjectParameterivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetObjectParameterivARB(uint obj, ArbShaderObjects pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetOcclusionQueryivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetOcclusionQueryivNV(uint id, NvOcclusionQuery pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetOcclusionQueryuivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetOcclusionQueryuivNV(uint id, NvOcclusionQuery pname, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPerfMonitorCounterDataAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetPerfMonitorCounterDataAMD(uint monitor, AmdPerformanceMonitor pname, int dataSize, [Out] uint* data, [Out] int* bytesWritten);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPerfMonitorCounterInfoAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetPerfMonitorCounterInfoAMD(uint group, uint counter, AmdPerformanceMonitor pname, [Out] IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPerfMonitorCountersAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetPerfMonitorCountersAMD(uint group, [Out] int* numCounters, [Out] int* maxActiveCounters, int counterSize, [Out] uint* counters);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPerfMonitorCounterStringAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, [Out] int* length, [Out] StringBuilder counterString);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPerfMonitorGroupsAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetPerfMonitorGroupsAMD([Out] int* numGroups, int groupsSize, [Out] uint* groups);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPerfMonitorGroupStringAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetPerfMonitorGroupStringAMD(uint group, int bufSize, [Out] int* length, [Out] StringBuilder groupString);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPixelMapfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetPixelMapfv(PixelMap map, [Out] float* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPixelMapuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetPixelMapuiv(PixelMap map, [Out] uint* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPixelMapusv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetPixelMapusv(PixelMap map, [Out] ushort* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPixelTexGenParameterfvSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetPixelTexGenParameterfvSGIS(SgisPixelTexture pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPixelTexGenParameterivSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetPixelTexGenParameterivSGIS(SgisPixelTexture pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPointerIndexedvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetPointerIndexedvEXT(ExtDirectStateAccess target, uint index, [Out] IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPointerv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetPointerv(GetPointervPName pname, [Out] IntPtr @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPointervEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetPointervEXT(GetPointervPName pname, [Out] IntPtr @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetPolygonStipple", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetPolygonStipple([Out] byte* mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramBinary", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramBinary(uint program, int bufSize, [Out] int* length, [Out] BinaryFormat* binaryFormat, [Out] IntPtr binary);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramEnvParameterdvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramEnvParameterdvARB(ArbVertexProgram target, uint index, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramEnvParameterfvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramEnvParameterfvARB(ArbVertexProgram target, uint index, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramEnvParameterIivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramEnvParameterIivNV(NvGpuProgram4 target, uint index, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramEnvParameterIuivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramEnvParameterIuivNV(NvGpuProgram4 target, uint index, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramInfoLog(uint program, int bufSize, [Out] int* length, [Out] StringBuilder infoLog);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramiv(uint program, ProgramParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramivARB(AssemblyProgramTargetArb target, AssemblyProgramParameterArb pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramivNV(uint id, NvVertexProgram pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramLocalParameterdvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramLocalParameterdvARB(ArbVertexProgram target, uint index, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramLocalParameterfvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramLocalParameterfvARB(ArbVertexProgram target, uint index, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramLocalParameterIivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramLocalParameterIivNV(NvGpuProgram4 target, uint index, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramLocalParameterIuivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramLocalParameterIuivNV(NvGpuProgram4 target, uint index, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramNamedParameterdvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramNamedParameterdvNV(uint id, int len, byte* name, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramNamedParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramNamedParameterfvNV(uint id, int len, byte* name, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramParameterdvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramParameterdvNV(AssemblyProgramTargetArb target, uint index, AssemblyProgramParameterArb pname, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramParameterfvNV(AssemblyProgramTargetArb target, uint index, AssemblyProgramParameterArb pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramPipelineInfoLog", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramPipelineInfoLog(uint pipeline, int bufSize, [Out] int* length, [Out] StringBuilder infoLog);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramPipelineiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramPipelineiv(uint pipeline, ProgramPipelineParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramStageiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramStageiv(uint program, ShaderType shadertype, ProgramStageParameter pname, [Out] int* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramStringARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetProgramStringARB(AssemblyProgramTargetArb target, AssemblyProgramParameterArb pname, [Out] IntPtr @string);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramStringNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramStringNV(uint id, NvVertexProgram pname, [Out] byte* program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetProgramSubroutineParameteruivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetProgramSubroutineParameteruivNV(NvGpuProgram5 target, uint index, [Out] uint* param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetQueryIndexediv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetQueryIndexediv(QueryTarget target, uint index, GetQueryParam pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetQueryiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetQueryiv(QueryTarget target, GetQueryParam pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetQueryivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetQueryivARB(ArbOcclusionQuery target, ArbOcclusionQuery pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetQueryObjecti64v", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetQueryObjecti64v(uint id, ArbTimerQuery pname, [Out] long* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetQueryObjecti64vEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetQueryObjecti64vEXT(uint id, ExtTimerQuery pname, [Out] long* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetQueryObjectiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetQueryObjectiv(uint id, GetQueryObjectParam pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetQueryObjectivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetQueryObjectivARB(uint id, ArbOcclusionQuery pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetQueryObjectui64v", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetQueryObjectui64v(uint id, ArbTimerQuery pname, [Out] ulong* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetQueryObjectui64vEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetQueryObjectui64vEXT(uint id, ExtTimerQuery pname, [Out] ulong* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetQueryObjectuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetQueryObjectuiv(uint id, GetQueryObjectParam pname, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetQueryObjectuivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetQueryObjectuivARB(uint id, ArbOcclusionQuery pname, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetRenderbufferParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetRenderbufferParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetRenderbufferParameterivEXT(RenderbufferTarget target, RenderbufferParameterName pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetSamplerParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetSamplerParameterfv(uint sampler, SamplerParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetSamplerParameterIiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetSamplerParameterIiv(uint sampler, ArbSamplerObjects pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetSamplerParameterIuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetSamplerParameterIuiv(uint sampler, ArbSamplerObjects pname, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetSamplerParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetSamplerParameteriv(uint sampler, SamplerParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetSeparableFilter", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetSeparableFilter(SeparableTarget target, PixelFormat format, PixelType type, [Out] IntPtr row, [Out] IntPtr column, [Out] IntPtr span);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetSeparableFilterEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetSeparableFilterEXT(ExtConvolution target, PixelFormat format, PixelType type, [Out] IntPtr row, [Out] IntPtr column, [Out] IntPtr span);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetShaderInfoLog(uint shader, int bufSize, [Out] int* length, [Out] StringBuilder infoLog);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetShaderiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetShaderiv(uint shader, ShaderParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetShaderPrecisionFormat", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetShaderPrecisionFormat(ShaderType shadertype, ShaderPrecisionType precisiontype, [Out] int* range, [Out] int* precision);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetShaderSource", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetShaderSource(uint shader, int bufSize, [Out] int* length, [Out] StringBuilder source);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetShaderSourceARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetShaderSourceARB(uint obj, int maxLength, [Out] int* length, [Out] StringBuilder source);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetSharpenTexFuncSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetSharpenTexFuncSGIS(TextureTarget target, [Out] float* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetString", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr GetString(StringName name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetStringi", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr GetStringi(StringName name, uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetSubroutineIndex", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetSubroutineIndex(uint program, ShaderType shadertype, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetSubroutineUniformLocation", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetSubroutineUniformLocation(uint program, ShaderType shadertype, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetSynciv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetSynciv(IntPtr sync, ArbSync pname, int bufSize, [Out] int* length, [Out] int* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexBumpParameterfvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexBumpParameterfvATI(AtiEnvmapBumpmap pname, [Out] float* param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexBumpParameterivATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexBumpParameterivATI(AtiEnvmapBumpmap pname, [Out] int* param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexEnvfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexEnviv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexFilterFuncSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexFilterFuncSGIS(TextureTarget target, SgisTextureFilter4 filter, [Out] float* weights);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexGendv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexGendv(TextureCoordName coord, TextureGenParameter pname, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexGenfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexGenfv(TextureCoordName coord, TextureGenParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexGeniv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexGeniv(TextureCoordName coord, TextureGenParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexImage", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, [Out] IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexParameterIiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexParameterIivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexParameterIuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexParameterIuivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTexParameterPointervAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetTexParameterPointervAPPLE(AppleTextureRange target, AppleTextureRange pname, [Out] IntPtr @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTextureImageEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetTextureImageEXT(uint texture, TextureTarget target, int level, PixelFormat format, PixelType type, [Out] IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTextureLevelParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTextureLevelParameterfvEXT(uint texture, TextureTarget target, int level, GetTextureParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTextureLevelParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTextureLevelParameterivEXT(uint texture, TextureTarget target, int level, GetTextureParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTextureParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTextureParameterfvEXT(uint texture, TextureTarget target, GetTextureParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTextureParameterIivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTextureParameterIivEXT(uint texture, TextureTarget target, GetTextureParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTextureParameterIuivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTextureParameterIuivEXT(uint texture, TextureTarget target, GetTextureParameter pname, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTextureParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTextureParameterivEXT(uint texture, TextureTarget target, GetTextureParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTrackMatrixivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTrackMatrixivNV(AssemblyProgramTargetArb target, uint address, AssemblyProgramParameterArb pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTransformFeedbackVarying", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTransformFeedbackVarying(uint program, uint index, int bufSize, [Out] int* length, [Out] int* size, [Out] ActiveAttribType* type, [Out] StringBuilder name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTransformFeedbackVaryingEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, [Out] int* length, [Out] int* size, [Out] ExtTransformFeedback* type, [Out] StringBuilder name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetTransformFeedbackVaryingNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetTransformFeedbackVaryingNV(uint program, uint index, [Out] int* location);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformBlockIndex", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetUniformBlockIndex(uint program, string uniformBlockName);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformBufferSizeEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetUniformBufferSizeEXT(uint program, int location);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformdv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetUniformdv(uint program, int location, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetUniformfv(uint program, int location, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformfvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetUniformfvARB(uint programObj, int location, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformi64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetUniformi64vNV(uint program, int location, [Out] long* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformIndices", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetUniformIndices(uint program, int uniformCount, string[] uniformNames, [Out] uint* uniformIndices);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetUniformiv(uint program, int location, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetUniformivARB(uint programObj, int location, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetUniformLocation(uint program, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformLocationARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetUniformLocationARB(uint programObj, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformOffsetEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr GetUniformOffsetEXT(uint program, int location);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformSubroutineuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetUniformSubroutineuiv(ShaderType shadertype, int location, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetUniformui64vNV(uint program, int location, [Out] ulong* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetUniformuiv(uint program, int location, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetUniformuivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetUniformuivEXT(uint program, int location, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVariantArrayObjectfvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVariantArrayObjectfvATI(uint id, AtiVertexArrayObject pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVariantArrayObjectivATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVariantArrayObjectivATI(uint id, AtiVertexArrayObject pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVariantBooleanvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVariantBooleanvEXT(uint id, ExtVertexShader value, [Out] bool* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVariantFloatvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVariantFloatvEXT(uint id, ExtVertexShader value, [Out] float* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVariantIntegervEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVariantIntegervEXT(uint id, ExtVertexShader value, [Out] int* data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVariantPointervEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetVariantPointervEXT(uint id, ExtVertexShader value, [Out] IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVaryingLocationNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int GetVaryingLocationNV(uint program, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribArrayObjectfvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribArrayObjectfvATI(uint index, AtiVertexAttribArrayObject pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribArrayObjectivATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribArrayObjectivATI(uint index, AtiVertexAttribArrayObject pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribdv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribdv(uint index, VertexAttribParameter pname, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribdvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribdvARB(uint index, VertexAttribParameterArb pname, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribdvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribdvNV(uint index, NvVertexProgram pname, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribfv(uint index, VertexAttribParameter pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribfvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribfvARB(uint index, VertexAttribParameterArb pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribfvNV(uint index, NvVertexProgram pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribIiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribIiv(uint index, VertexAttribParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribIivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribIivEXT(uint index, NvVertexProgram4 pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribIuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribIuiv(uint index, VertexAttribParameter pname, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribIuivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribIuivEXT(uint index, NvVertexProgram4 pname, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribiv(uint index, VertexAttribParameter pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribivARB(uint index, VertexAttribParameterArb pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribivNV(uint index, NvVertexProgram pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribLdv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribLdv(uint index, VertexAttribParameter pname, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribLdvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribLdvEXT(uint index, ExtVertexAttrib64bit pname, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribLi64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribLi64vNV(uint index, NvVertexAttribInteger64bit pname, [Out] long* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribLui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVertexAttribLui64vNV(uint index, NvVertexAttribInteger64bit pname, [Out] ulong* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetVertexAttribPointerv(uint index, VertexAttribPointerParameter pname, [Out] IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribPointervARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetVertexAttribPointervARB(uint index, VertexAttribPointerParameterArb pname, [Out] IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVertexAttribPointervNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetVertexAttribPointervNV(uint index, NvVertexProgram pname, [Out] IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVideoCaptureivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVideoCaptureivNV(uint video_capture_slot, NvVideoCapture pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVideoCaptureStreamdvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVideoCaptureStreamdvNV(uint video_capture_slot, uint stream, NvVideoCapture pname, [Out] double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVideoCaptureStreamfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVideoCaptureStreamfvNV(uint video_capture_slot, uint stream, NvVideoCapture pname, [Out] float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVideoCaptureStreamivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVideoCaptureStreamivNV(uint video_capture_slot, uint stream, NvVideoCapture pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVideoi64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVideoi64vNV(uint video_slot, NvPresentVideo pname, [Out] long* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVideoivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVideoivNV(uint video_slot, NvPresentVideo pname, [Out] int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVideoui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVideoui64vNV(uint video_slot, NvPresentVideo pname, [Out] ulong* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGetVideouivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void GetVideouivNV(uint video_slot, NvPresentVideo pname, [Out] uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGlobalAlphaFactorbSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GlobalAlphaFactorbSUN(sbyte factor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGlobalAlphaFactordSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GlobalAlphaFactordSUN(double factor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGlobalAlphaFactorfSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GlobalAlphaFactorfSUN(float factor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGlobalAlphaFactoriSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GlobalAlphaFactoriSUN(int factor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGlobalAlphaFactorsSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GlobalAlphaFactorsSUN(short factor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGlobalAlphaFactorubSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GlobalAlphaFactorubSUN(byte factor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGlobalAlphaFactoruiSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GlobalAlphaFactoruiSUN(uint factor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glGlobalAlphaFactorusSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GlobalAlphaFactorusSUN(ushort factor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glHint", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Hint(HintTarget target, HintMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glHintPGI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void HintPGI(PgiMiscHints target, int mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glHistogram", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Histogram(HistogramTarget target, int width, PixelInternalFormat internalformat, bool sink);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glHistogramEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void HistogramEXT(ExtHistogram target, int width, PixelInternalFormat internalformat, bool sink);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIglooInterfaceSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void IglooInterfaceSGIX(All pname, IntPtr @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glImageTransformParameterfHP", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ImageTransformParameterfHP(HpImageTransform target, HpImageTransform pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glImageTransformParameterfvHP", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ImageTransformParameterfvHP(HpImageTransform target, HpImageTransform pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glImageTransformParameteriHP", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ImageTransformParameteriHP(HpImageTransform target, HpImageTransform pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glImageTransformParameterivHP", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ImageTransformParameterivHP(HpImageTransform target, HpImageTransform pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexd", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Indexd(double c);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexdv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Indexdv(double* c);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Indexf(float c);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexFormatNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void IndexFormatNV(NvVertexBufferUnifiedMemory type, int stride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexFuncEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void IndexFuncEXT(ExtIndexFunc func, float @ref);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Indexfv(float* c);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexi", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Indexi(int c);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Indexiv(int* c);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexMask", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void IndexMask(uint mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexMaterialEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void IndexMaterialEXT(MaterialFace face, ExtIndexMaterial mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexPointer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void IndexPointer(IndexPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void IndexPointerEXT(IndexPointerType type, int stride, int count, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexPointerListIBM", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void IndexPointerListIBM(IndexPointerType type, int stride, IntPtr pointer, int ptrstride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexs", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Indexs(short c);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexsv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Indexsv(short* c);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexub", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Indexub(byte c);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIndexubv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Indexubv(byte* c);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glInitNames", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void InitNames();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glInsertComponentEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void InsertComponentEXT(uint res, uint src, uint num);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glInstrumentsBufferSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void InstrumentsBufferSGIX(int size, [Out] int* buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glInterleavedArrays", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void InterleavedArrays(InterleavedArrayFormat format, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsAsyncMarkerSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsAsyncMarkerSGIX(uint marker);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsBuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsBuffer(uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsBufferARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsBufferARB(uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsBufferResidentNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsBufferResidentNV(NvShaderBufferLoad target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsEnabled", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsEnabled(EnableCap cap);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsEnabledi", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsEnabledi(IndexedEnableCap target, uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsEnabledIndexedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsEnabledIndexedEXT(IndexedEnableCap target, uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsFenceAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsFenceAPPLE(uint fence);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsFenceNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsFenceNV(uint fence);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsFramebuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsFramebuffer(uint framebuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsFramebufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsFramebufferEXT(uint framebuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsList", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsList(uint list);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsNameAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsNameAMD(AmdNameGenDelete identifier, uint name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsNamedBufferResidentNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsNamedBufferResidentNV(uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsNamedStringARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsNamedStringARB(int namelen, string name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsObjectBufferATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsObjectBufferATI(uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsOcclusionQueryNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsOcclusionQueryNV(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsProgram", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsProgram(uint program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsProgramARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsProgramARB(uint program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsProgramNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsProgramNV(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsProgramPipeline", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsProgramPipeline(uint pipeline);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsQuery", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsQuery(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsQueryARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsQueryARB(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsRenderbuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsRenderbuffer(uint renderbuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsRenderbufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsRenderbufferEXT(uint renderbuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsSampler", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsSampler(uint sampler);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsShader", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsShader(uint shader);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsSync", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsSync(IntPtr sync);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsTexture", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsTexture(uint texture);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsTextureEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsTextureEXT(uint texture);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsTransformFeedback", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsTransformFeedback(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsTransformFeedbackNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsTransformFeedbackNV(uint id);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsVariantEnabledEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsVariantEnabledEXT(uint id, ExtVertexShader cap);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsVertexArray", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsVertexArray(uint array);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsVertexArrayAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsVertexArrayAPPLE(uint array);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glIsVertexAttribEnabledAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool IsVertexAttribEnabledAPPLE(uint index, AppleVertexProgramEvaluators pname);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLightEnviSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LightEnviSGIX(SgixFragmentLighting pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLightf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Lightf(LightName light, LightParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLightfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Lightfv(LightName light, LightParameter pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLighti", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Lighti(LightName light, LightParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLightiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Lightiv(LightName light, LightParameter pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLightModelf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LightModelf(LightModelParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLightModelfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void LightModelfv(LightModelParameter pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLightModeli", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LightModeli(LightModelParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLightModeliv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void LightModeliv(LightModelParameter pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLineStipple", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LineStipple(int factor, ushort pattern);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLineWidth", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LineWidth(float width);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLinkProgram", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LinkProgram(uint program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLinkProgramARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LinkProgramARB(uint programObj);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glListBase", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ListBase(uint @base);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glListParameterfSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ListParameterfSGIX(uint list, ListParameterName pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glListParameterfvSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ListParameterfvSGIX(uint list, ListParameterName pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glListParameteriSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ListParameteriSGIX(uint list, ListParameterName pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glListParameterivSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ListParameterivSGIX(uint list, ListParameterName pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLoadIdentity", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LoadIdentity();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLoadIdentityDeformationMapSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LoadIdentityDeformationMapSGIX(uint mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLoadMatrixd", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void LoadMatrixd(double* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void LoadMatrixf(float* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLoadName", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LoadName(uint name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLoadProgramNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void LoadProgramNV(AssemblyProgramTargetArb target, uint id, int len, byte* program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLoadTransposeMatrixd", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void LoadTransposeMatrixd(double* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLoadTransposeMatrixdARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void LoadTransposeMatrixdARB(double* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLoadTransposeMatrixf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void LoadTransposeMatrixf(float* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLoadTransposeMatrixfARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void LoadTransposeMatrixfARB(float* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLockArraysEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LockArraysEXT(int first, int count);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glLogicOp", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void LogicOp(LogicOp opcode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMakeBufferNonResidentNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MakeBufferNonResidentNV(NvShaderBufferLoad target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMakeBufferResidentNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MakeBufferResidentNV(NvShaderBufferLoad target, NvShaderBufferLoad access);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMakeNamedBufferNonResidentNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MakeNamedBufferNonResidentNV(uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMakeNamedBufferResidentNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MakeNamedBufferResidentNV(uint buffer, NvShaderBufferLoad access);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMap1d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Map1d(MapTarget target, double u1, double u2, int stride, int order, double* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMap1f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Map1f(MapTarget target, float u1, float u2, int stride, int order, float* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMap2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Map2d(MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMap2f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Map2f(MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapBuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr MapBuffer(BufferTarget target, BufferAccess access);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapBufferARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr MapBufferARB(BufferTargetArb target, ArbVertexBufferObject access);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapBufferRange", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr MapBufferRange(BufferTarget target, IntPtr offset, IntPtr length, BufferAccessMask access);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapControlPointsNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MapControlPointsNV(NvEvaluators target, uint index, NvEvaluators type, int ustride, int vstride, int uorder, int vorder, bool packed, IntPtr points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapGrid1d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MapGrid1d(int un, double u1, double u2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapGrid1f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MapGrid1f(int un, float u1, float u2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapGrid2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapGrid2f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapNamedBufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr MapNamedBufferEXT(uint buffer, ExtDirectStateAccess access);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapNamedBufferRangeEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr MapNamedBufferRangeEXT(uint buffer, IntPtr offset, IntPtr length, BufferAccessMask access);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapObjectBufferATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr MapObjectBufferATI(uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MapParameterfvNV(NvEvaluators target, NvEvaluators pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapParameterivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MapParameterivNV(NvEvaluators target, NvEvaluators pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapVertexAttrib1dAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MapVertexAttrib1dAPPLE(uint index, uint size, double u1, double u2, int stride, int order, double* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapVertexAttrib1fAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MapVertexAttrib1fAPPLE(uint index, uint size, float u1, float u2, int stride, int order, float* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapVertexAttrib2dAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MapVertexAttrib2dAPPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMapVertexAttrib2fAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MapVertexAttrib2fAPPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMaterialf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Materialf(MaterialFace face, MaterialParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMaterialfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Materialfv(MaterialFace face, MaterialParameter pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMateriali", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Materiali(MaterialFace face, MaterialParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMaterialiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Materialiv(MaterialFace face, MaterialParameter pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixFrustumEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixFrustumEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixIndexPointerARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixIndexPointerARB(int size, ArbMatrixPalette type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixIndexubvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MatrixIndexubvARB(int size, byte* indices);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixIndexuivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MatrixIndexuivARB(int size, uint* indices);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixIndexusvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MatrixIndexusvARB(int size, ushort* indices);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixLoaddEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MatrixLoaddEXT(MatrixMode mode, double* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixLoadfEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MatrixLoadfEXT(MatrixMode mode, float* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixLoadIdentityEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixLoadIdentityEXT(MatrixMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixLoadTransposedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MatrixLoadTransposedEXT(MatrixMode mode, double* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixLoadTransposefEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MatrixLoadTransposefEXT(MatrixMode mode, float* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixMode", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixMode(MatrixMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixMultdEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MatrixMultdEXT(MatrixMode mode, double* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixMultfEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MatrixMultfEXT(MatrixMode mode, float* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixMultTransposedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MatrixMultTransposedEXT(MatrixMode mode, double* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixMultTransposefEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MatrixMultTransposefEXT(MatrixMode mode, float* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixOrthoEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixOrthoEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixPopEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixPopEXT(MatrixMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixPushEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixPushEXT(MatrixMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixRotatedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixRotatedEXT(MatrixMode mode, double angle, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixRotatefEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixRotatefEXT(MatrixMode mode, float angle, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixScaledEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixScaledEXT(MatrixMode mode, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixScalefEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixScalefEXT(MatrixMode mode, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixTranslatedEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixTranslatedEXT(MatrixMode mode, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMatrixTranslatefEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MatrixTranslatefEXT(MatrixMode mode, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMemoryBarrierEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MemoryBarrierEXT(uint barriers);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMinmax", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Minmax(MinmaxTarget target, PixelInternalFormat internalformat, bool sink);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMinmaxEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MinmaxEXT(ExtHistogram target, PixelInternalFormat internalformat, bool sink);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMinSampleShading", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MinSampleShading(float value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMinSampleShadingARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MinSampleShadingARB(float value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiDrawArrays", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiDrawArrays(BeginMode mode, int* first, int* count, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiDrawArraysEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiDrawArraysEXT(BeginMode mode, int* first, int* count, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiDrawElementArrayAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiDrawElementArrayAPPLE(BeginMode mode, int* first, int* count, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiDrawElements", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiDrawElements(BeginMode mode, int* count, DrawElementsType type, IntPtr indices, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiDrawElementsBaseVertex", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiDrawElementsBaseVertex(BeginMode mode, int* count, DrawElementsType type, IntPtr indices, int primcount, int* basevertex);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiDrawElementsEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiDrawElementsEXT(BeginMode mode, int* count, DrawElementsType type, IntPtr indices, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiDrawRangeElementArrayAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiDrawRangeElementArrayAPPLE(BeginMode mode, uint start, uint end, int* first, int* count, int primcount);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiModeDrawArraysIBM", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiModeDrawArraysIBM(BeginMode* mode, int* first, int* count, int primcount, int modestride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiModeDrawElementsIBM", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiModeDrawElementsIBM(BeginMode* mode, int* count, DrawElementsType type, IntPtr indices, int primcount, int modestride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexBufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexBufferEXT(TextureUnit texunit, TextureTarget target, ExtDirectStateAccess internalformat, uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord1d(TextureUnit target, double s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord1dARB(TextureUnit target, double s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord1dv(TextureUnit target, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord1dvARB(TextureUnit target, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord1f(TextureUnit target, float s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord1fARB(TextureUnit target, float s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord1fv(TextureUnit target, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord1fvARB(TextureUnit target, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord1i(TextureUnit target, int s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1iARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord1iARB(TextureUnit target, int s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord1iv(TextureUnit target, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1ivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord1ivARB(TextureUnit target, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord1s(TextureUnit target, short s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1sARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord1sARB(TextureUnit target, short s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord1sv(TextureUnit target, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord1svARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord1svARB(TextureUnit target, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord2d(TextureUnit target, double s, double t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord2dARB(TextureUnit target, double s, double t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord2dv(TextureUnit target, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord2dvARB(TextureUnit target, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord2f(TextureUnit target, float s, float t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord2fARB(TextureUnit target, float s, float t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord2fv(TextureUnit target, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord2fvARB(TextureUnit target, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord2i(TextureUnit target, int s, int t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2iARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord2iARB(TextureUnit target, int s, int t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord2iv(TextureUnit target, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2ivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord2ivARB(TextureUnit target, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord2s(TextureUnit target, short s, short t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2sARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord2sARB(TextureUnit target, short s, short t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord2sv(TextureUnit target, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord2svARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord2svARB(TextureUnit target, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord3d(TextureUnit target, double s, double t, double r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord3dARB(TextureUnit target, double s, double t, double r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord3dv(TextureUnit target, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord3dvARB(TextureUnit target, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord3f(TextureUnit target, float s, float t, float r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord3fARB(TextureUnit target, float s, float t, float r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord3fv(TextureUnit target, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord3fvARB(TextureUnit target, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord3i(TextureUnit target, int s, int t, int r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3iARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord3iARB(TextureUnit target, int s, int t, int r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord3iv(TextureUnit target, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3ivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord3ivARB(TextureUnit target, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord3s(TextureUnit target, short s, short t, short r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3sARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord3sARB(TextureUnit target, short s, short t, short r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord3sv(TextureUnit target, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord3svARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord3svARB(TextureUnit target, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord4d(TextureUnit target, double s, double t, double r, double q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord4dARB(TextureUnit target, double s, double t, double r, double q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord4dv(TextureUnit target, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord4dvARB(TextureUnit target, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord4f(TextureUnit target, float s, float t, float r, float q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord4fARB(TextureUnit target, float s, float t, float r, float q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord4fv(TextureUnit target, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord4fvARB(TextureUnit target, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord4i(TextureUnit target, int s, int t, int r, int q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4iARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord4iARB(TextureUnit target, int s, int t, int r, int q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord4iv(TextureUnit target, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4ivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord4ivARB(TextureUnit target, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord4s(TextureUnit target, short s, short t, short r, short q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4sARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoord4sARB(TextureUnit target, short s, short t, short r, short q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord4sv(TextureUnit target, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoord4svARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoord4svARB(TextureUnit target, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoordP1ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoordP1ui(TextureUnit texture, PackedPointerType type, uint coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoordP1uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoordP1uiv(TextureUnit texture, PackedPointerType type, uint* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoordP2ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoordP2ui(TextureUnit texture, PackedPointerType type, uint coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoordP2uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoordP2uiv(TextureUnit texture, PackedPointerType type, uint* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoordP3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoordP3ui(TextureUnit texture, PackedPointerType type, uint coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoordP3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoordP3uiv(TextureUnit texture, PackedPointerType type, uint* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoordP4ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoordP4ui(TextureUnit texture, PackedPointerType type, uint coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoordP4uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexCoordP4uiv(TextureUnit texture, PackedPointerType type, uint* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexCoordPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexCoordPointerEXT(TextureUnit texunit, int size, TexCoordPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexEnvfEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexEnvfEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexEnvfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexEnvfvEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexEnviEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexEnviEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexEnvivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexEnvivEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexGendEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexGendEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, double param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexGendvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexGendvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexGenfEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexGenfEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexGenfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexGenfvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexGeniEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexGeniEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexGenivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexGenivEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexImage3DEXT(TextureUnit texunit, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexParameterfEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexParameterfEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexParameterfvEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexParameteriEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexParameteriEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexParameterIivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexParameterIivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexParameterIuivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexParameterIuivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultiTexParameterivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexRenderbufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexRenderbufferEXT(TextureUnit texunit, TextureTarget target, uint renderbuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexSubImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexSubImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultiTexSubImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void MultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultMatrixd", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultMatrixd(double* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultMatrixf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultMatrixf(float* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultTransposeMatrixd", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultTransposeMatrixd(double* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultTransposeMatrixdARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultTransposeMatrixdARB(double* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultTransposeMatrixf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultTransposeMatrixf(float* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glMultTransposeMatrixfARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void MultTransposeMatrixfARB(float* m);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedBufferDataEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedBufferDataEXT(uint buffer, IntPtr size, IntPtr data, ExtDirectStateAccess usage);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedBufferSubDataEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedBufferSubDataEXT(uint buffer, IntPtr offset, IntPtr size, IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedCopyBufferSubDataEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedCopyBufferSubDataEXT(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedFramebufferRenderbufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedFramebufferRenderbufferEXT(uint framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedFramebufferTexture1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedFramebufferTexture1DEXT(uint framebuffer, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedFramebufferTexture2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedFramebufferTexture2DEXT(uint framebuffer, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedFramebufferTexture3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedFramebufferTexture3DEXT(uint framebuffer, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedFramebufferTextureEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedFramebufferTextureEXT(uint framebuffer, FramebufferAttachment attachment, uint texture, int level);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedFramebufferTextureFaceEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedFramebufferTextureFaceEXT(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, TextureTarget face);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedFramebufferTextureLayerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedFramebufferTextureLayerEXT(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, int layer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramLocalParameter4dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedProgramLocalParameter4dEXT(uint program, ExtDirectStateAccess target, uint index, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramLocalParameter4dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NamedProgramLocalParameter4dvEXT(uint program, ExtDirectStateAccess target, uint index, double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramLocalParameter4fEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedProgramLocalParameter4fEXT(uint program, ExtDirectStateAccess target, uint index, float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramLocalParameter4fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NamedProgramLocalParameter4fvEXT(uint program, ExtDirectStateAccess target, uint index, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramLocalParameterI4iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedProgramLocalParameterI4iEXT(uint program, ExtDirectStateAccess target, uint index, int x, int y, int z, int w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramLocalParameterI4ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NamedProgramLocalParameterI4ivEXT(uint program, ExtDirectStateAccess target, uint index, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramLocalParameterI4uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedProgramLocalParameterI4uiEXT(uint program, ExtDirectStateAccess target, uint index, uint x, uint y, uint z, uint w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramLocalParameterI4uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NamedProgramLocalParameterI4uivEXT(uint program, ExtDirectStateAccess target, uint index, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramLocalParameters4fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NamedProgramLocalParameters4fvEXT(uint program, ExtDirectStateAccess target, uint index, int count, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramLocalParametersI4ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NamedProgramLocalParametersI4ivEXT(uint program, ExtDirectStateAccess target, uint index, int count, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramLocalParametersI4uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NamedProgramLocalParametersI4uivEXT(uint program, ExtDirectStateAccess target, uint index, int count, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedProgramStringEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedProgramStringEXT(uint program, ExtDirectStateAccess target, ExtDirectStateAccess format, int len, IntPtr @string);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedRenderbufferStorageEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedRenderbufferStorageEXT(uint renderbuffer, PixelInternalFormat internalformat, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedRenderbufferStorageMultisampleCoverageEXT(uint renderbuffer, int coverageSamples, int colorSamples, PixelInternalFormat internalformat, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedRenderbufferStorageMultisampleEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedRenderbufferStorageMultisampleEXT(uint renderbuffer, int samples, PixelInternalFormat internalformat, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNamedStringARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NamedStringARB(ArbShadingLanguageInclude type, int namelen, string name, int stringlen, string @string);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNewList", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NewList(uint list, ListMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNewObjectBufferATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int NewObjectBufferATI(int size, IntPtr pointer, AtiVertexArrayObject usage);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3b", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Normal3b(sbyte nx, sbyte ny, sbyte nz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3bv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Normal3bv(sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Normal3d(double nx, double ny, double nz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Normal3dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Normal3f(float nx, float ny, float nz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Normal3fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Normal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Normal3fVertex3fvSUN(float* n, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Normal3i(int nx, int ny, int nz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Normal3iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Normal3s(short nx, short ny, short nz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormal3sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Normal3sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalFormatNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NormalFormatNV(NvVertexBufferUnifiedMemory type, int stride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalP3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NormalP3ui(PackedPointerType type, uint coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalP3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NormalP3uiv(PackedPointerType type, uint* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalPointer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NormalPointer(NormalPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NormalPointerEXT(NormalPointerType type, int stride, int count, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalPointerListIBM", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NormalPointerListIBM(NormalPointerType type, int stride, IntPtr pointer, int ptrstride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalPointervINTEL", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NormalPointervINTEL(NormalPointerType type, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalStream3bATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NormalStream3bATI(AtiVertexStreams stream, sbyte nx, sbyte ny, sbyte nz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalStream3bvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NormalStream3bvATI(AtiVertexStreams stream, sbyte* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalStream3dATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NormalStream3dATI(AtiVertexStreams stream, double nx, double ny, double nz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalStream3dvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NormalStream3dvATI(AtiVertexStreams stream, double* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalStream3fATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NormalStream3fATI(AtiVertexStreams stream, float nx, float ny, float nz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalStream3fvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NormalStream3fvATI(AtiVertexStreams stream, float* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalStream3iATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NormalStream3iATI(AtiVertexStreams stream, int nx, int ny, int nz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalStream3ivATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NormalStream3ivATI(AtiVertexStreams stream, int* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalStream3sATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void NormalStream3sATI(AtiVertexStreams stream, short nx, short ny, short nz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glNormalStream3svATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void NormalStream3svATI(AtiVertexStreams stream, short* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glObjectPurgeableAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern AppleObjectPurgeable ObjectPurgeableAPPLE(AppleObjectPurgeable objectType, uint name, AppleObjectPurgeable option);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glObjectUnpurgeableAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern AppleObjectPurgeable ObjectUnpurgeableAPPLE(AppleObjectPurgeable objectType, uint name, AppleObjectPurgeable option);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glOrtho", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Ortho(double left, double right, double bottom, double top, double zNear, double zFar);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPassTexCoordATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PassTexCoordATI(uint dst, uint coord, AtiFragmentShader swizzle);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPassThrough", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PassThrough(float token);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPatchParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PatchParameterfv(PatchParameterFloat pname, float* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPatchParameteri", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PatchParameteri(PatchParameterInt pname, int value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPauseTransformFeedback", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PauseTransformFeedback();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPauseTransformFeedbackNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PauseTransformFeedbackNV();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelDataRangeNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PixelDataRangeNV(NvPixelDataRange target, int length, [Out] IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelMapfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PixelMapfv(PixelMap map, int mapsize, float* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelMapuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PixelMapuiv(PixelMap map, int mapsize, uint* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelMapusv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PixelMapusv(PixelMap map, int mapsize, ushort* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelStoref", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PixelStoref(PixelStoreParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelStorei", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PixelStorei(PixelStoreParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelTexGenParameterfSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PixelTexGenParameterfSGIS(SgisPixelTexture pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelTexGenParameterfvSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PixelTexGenParameterfvSGIS(SgisPixelTexture pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelTexGenParameteriSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PixelTexGenParameteriSGIS(SgisPixelTexture pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelTexGenParameterivSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PixelTexGenParameterivSGIS(SgisPixelTexture pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelTexGenSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PixelTexGenSGIX(SgixPixelTexture mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelTransferf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PixelTransferf(PixelTransferParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelTransferi", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PixelTransferi(PixelTransferParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelTransformParameterfEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PixelTransformParameterfEXT(ExtPixelTransform target, ExtPixelTransform pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelTransformParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PixelTransformParameterfvEXT(ExtPixelTransform target, ExtPixelTransform pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelTransformParameteriEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PixelTransformParameteriEXT(ExtPixelTransform target, ExtPixelTransform pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelTransformParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PixelTransformParameterivEXT(ExtPixelTransform target, ExtPixelTransform pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPixelZoom", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PixelZoom(float xfactor, float yfactor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPNTrianglesfATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PNTrianglesfATI(AtiPnTriangles pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPNTrianglesiATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PNTrianglesiATI(AtiPnTriangles pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameterf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PointParameterf(PointParameterName pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameterfARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PointParameterfARB(ArbPointParameters pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameterfEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PointParameterfEXT(ExtPointParameters pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameterfSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PointParameterfSGIS(SgisPointParameters pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PointParameterfv(PointParameterName pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameterfvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PointParameterfvARB(ArbPointParameters pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PointParameterfvEXT(ExtPointParameters pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameterfvSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PointParameterfvSGIS(SgisPointParameters pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameteri", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PointParameteri(PointParameterName pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameteriNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PointParameteriNV(NvPointSprite pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PointParameteriv(PointParameterName pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointParameterivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PointParameterivNV(NvPointSprite pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPointSize", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PointSize(float size);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPollAsyncSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern int PollAsyncSGIX([Out] uint* markerp);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPollInstrumentsSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern int PollInstrumentsSGIX([Out] int* marker_p);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPolygonMode", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PolygonMode(MaterialFace face, PolygonMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPolygonOffset", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PolygonOffset(float factor, float units);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPolygonOffsetEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PolygonOffsetEXT(float factor, float bias);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPolygonStipple", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PolygonStipple(byte* mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPopAttrib", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PopAttrib();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPopClientAttrib", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PopClientAttrib();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPopMatrix", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PopMatrix();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPopName", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PopName();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPresentFrameDualFillNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PresentFrameDualFillNV(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, NvPresentVideo type, NvPresentVideo target0, uint fill0, NvPresentVideo target1, uint fill1, NvPresentVideo target2, uint fill2, NvPresentVideo target3, uint fill3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPresentFrameKeyedNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PresentFrameKeyedNV(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, NvPresentVideo type, NvPresentVideo target0, uint fill0, uint key0, NvPresentVideo target1, uint fill1, uint key1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPrimitiveRestartIndex", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PrimitiveRestartIndex(uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPrimitiveRestartIndexNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PrimitiveRestartIndexNV(uint index);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPrimitiveRestartNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PrimitiveRestartNV();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPrioritizeTextures", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PrioritizeTextures(int n, uint* textures, float* priorities);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPrioritizeTexturesEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void PrioritizeTexturesEXT(int n, uint* textures, float* priorities);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramBinary", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramBinary(uint program, BinaryFormat binaryFormat, IntPtr binary, int length);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramBufferParametersfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramBufferParametersfvNV(NvParameterBufferObject target, uint buffer, uint index, int count, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramBufferParametersIivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramBufferParametersIivNV(NvParameterBufferObject target, uint buffer, uint index, int count, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramBufferParametersIuivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramBufferParametersIuivNV(NvParameterBufferObject target, uint buffer, uint index, int count, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramEnvParameter4dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramEnvParameter4dARB(AssemblyProgramTargetArb target, uint index, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramEnvParameter4dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramEnvParameter4dvARB(AssemblyProgramTargetArb target, uint index, double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramEnvParameter4fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramEnvParameter4fARB(AssemblyProgramTargetArb target, uint index, float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramEnvParameter4fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramEnvParameter4fvARB(AssemblyProgramTargetArb target, uint index, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramEnvParameterI4iNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramEnvParameterI4iNV(NvGpuProgram4 target, uint index, int x, int y, int z, int w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramEnvParameterI4ivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramEnvParameterI4ivNV(NvGpuProgram4 target, uint index, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramEnvParameterI4uiNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramEnvParameterI4uiNV(NvGpuProgram4 target, uint index, uint x, uint y, uint z, uint w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramEnvParameterI4uivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramEnvParameterI4uivNV(NvGpuProgram4 target, uint index, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramEnvParameters4fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramEnvParameters4fvEXT(ExtGpuProgramParameters target, uint index, int count, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramEnvParametersI4ivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramEnvParametersI4ivNV(NvGpuProgram4 target, uint index, int count, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramEnvParametersI4uivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramEnvParametersI4uivNV(NvGpuProgram4 target, uint index, int count, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramLocalParameter4dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramLocalParameter4dARB(AssemblyProgramTargetArb target, uint index, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramLocalParameter4dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramLocalParameter4dvARB(AssemblyProgramTargetArb target, uint index, double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramLocalParameter4fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramLocalParameter4fARB(AssemblyProgramTargetArb target, uint index, float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramLocalParameter4fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramLocalParameter4fvARB(AssemblyProgramTargetArb target, uint index, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramLocalParameterI4iNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramLocalParameterI4iNV(NvGpuProgram4 target, uint index, int x, int y, int z, int w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramLocalParameterI4ivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramLocalParameterI4ivNV(NvGpuProgram4 target, uint index, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramLocalParameterI4uiNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramLocalParameterI4uiNV(NvGpuProgram4 target, uint index, uint x, uint y, uint z, uint w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramLocalParameterI4uivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramLocalParameterI4uivNV(NvGpuProgram4 target, uint index, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramLocalParameters4fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramLocalParameters4fvEXT(ExtGpuProgramParameters target, uint index, int count, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramLocalParametersI4ivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramLocalParametersI4ivNV(NvGpuProgram4 target, uint index, int count, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramLocalParametersI4uivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramLocalParametersI4uivNV(NvGpuProgram4 target, uint index, int count, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramNamedParameter4dNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramNamedParameter4dNV(uint id, int len, byte* name, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramNamedParameter4dvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramNamedParameter4dvNV(uint id, int len, byte* name, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramNamedParameter4fNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramNamedParameter4fNV(uint id, int len, byte* name, float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramNamedParameter4fvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramNamedParameter4fvNV(uint id, int len, byte* name, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramParameter4dNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramParameter4dNV(AssemblyProgramTargetArb target, uint index, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramParameter4dvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramParameter4dvNV(AssemblyProgramTargetArb target, uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramParameter4fNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramParameter4fNV(AssemblyProgramTargetArb target, uint index, float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramParameter4fvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramParameter4fvNV(AssemblyProgramTargetArb target, uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramParameteri", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramParameteri(uint program, AssemblyProgramParameterArb pname, int value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramParameteriARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramParameteriARB(uint program, AssemblyProgramParameterArb pname, int value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramParameteriEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramParameteriEXT(uint program, AssemblyProgramParameterArb pname, int value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramParameters4dvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramParameters4dvNV(AssemblyProgramTargetArb target, uint index, int count, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramParameters4fvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramParameters4fvNV(AssemblyProgramTargetArb target, uint index, int count, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramStringARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramStringARB(AssemblyProgramTargetArb target, ArbVertexProgram format, int len, IntPtr @string);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramSubroutineParametersuivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramSubroutineParametersuivNV(NvGpuProgram5 target, int count, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform1d(uint program, int location, double v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform1dEXT(uint program, int location, double x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform1dv(uint program, int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform1dvEXT(uint program, int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform1f(uint program, int location, float v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1fEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform1fEXT(uint program, int location, float v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform1fv(uint program, int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform1fvEXT(uint program, int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform1i(uint program, int location, int v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform1i64NV(uint program, int location, long x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform1i64vNV(uint program, int location, int count, long* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform1iEXT(uint program, int location, int v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform1iv(uint program, int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform1ivEXT(uint program, int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform1ui(uint program, int location, uint v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform1ui64NV(uint program, int location, ulong x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform1ui64vNV(uint program, int location, int count, ulong* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform1uiEXT(uint program, int location, uint v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform1uiv(uint program, int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform1uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform1uivEXT(uint program, int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform2d(uint program, int location, double v0, double v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform2dEXT(uint program, int location, double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform2dv(uint program, int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform2dvEXT(uint program, int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform2f(uint program, int location, float v0, float v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2fEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform2fEXT(uint program, int location, float v0, float v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform2fv(uint program, int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform2fvEXT(uint program, int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform2i(uint program, int location, int v0, int v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform2i64NV(uint program, int location, long x, long y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform2i64vNV(uint program, int location, int count, long* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform2iEXT(uint program, int location, int v0, int v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform2iv(uint program, int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform2ivEXT(uint program, int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform2ui(uint program, int location, uint v0, uint v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform2ui64NV(uint program, int location, ulong x, ulong y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform2ui64vNV(uint program, int location, int count, ulong* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform2uiEXT(uint program, int location, uint v0, uint v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform2uiv(uint program, int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform2uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform2uivEXT(uint program, int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform3d(uint program, int location, double v0, double v1, double v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform3dEXT(uint program, int location, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform3dv(uint program, int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform3dvEXT(uint program, int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform3f(uint program, int location, float v0, float v1, float v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3fEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform3fEXT(uint program, int location, float v0, float v1, float v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform3fv(uint program, int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform3fvEXT(uint program, int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform3i(uint program, int location, int v0, int v1, int v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform3i64NV(uint program, int location, long x, long y, long z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform3i64vNV(uint program, int location, int count, long* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform3iEXT(uint program, int location, int v0, int v1, int v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform3iv(uint program, int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform3ivEXT(uint program, int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform3ui64NV(uint program, int location, ulong x, ulong y, ulong z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform3ui64vNV(uint program, int location, int count, ulong* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform3uiEXT(uint program, int location, uint v0, uint v1, uint v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform3uiv(uint program, int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform3uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform3uivEXT(uint program, int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform4dEXT(uint program, int location, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform4dv(uint program, int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform4dvEXT(uint program, int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4fEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform4fEXT(uint program, int location, float v0, float v1, float v2, float v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform4fv(uint program, int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform4fvEXT(uint program, int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform4i64NV(uint program, int location, long x, long y, long z, long w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform4i64vNV(uint program, int location, int count, long* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform4iEXT(uint program, int location, int v0, int v1, int v2, int v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform4iv(uint program, int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform4ivEXT(uint program, int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform4ui64NV(uint program, int location, ulong x, ulong y, ulong z, ulong w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform4ui64vNV(uint program, int location, int count, ulong* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniform4uiEXT(uint program, int location, uint v0, uint v1, uint v2, uint v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform4uiv(uint program, int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniform4uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniform4uivEXT(uint program, int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2dvEXT(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2fvEXT(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2x3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2x3dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2x3dvEXT(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2x3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2x3fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2x3fvEXT(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2x4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2x4dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2x4dvEXT(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2x4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix2x4fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix2x4fvEXT(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3dvEXT(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3fvEXT(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3x2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3x2dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3x2dvEXT(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3x2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3x2fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3x2fvEXT(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3x4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3x4dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3x4dvEXT(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3x4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix3x4fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix3x4fvEXT(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4dvEXT(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4fvEXT(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4x2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4x2dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4x2dvEXT(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4x2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4x2fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4x2fvEXT(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4x3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4x3dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4x3dvEXT(uint program, int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4x3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformMatrix4x3fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformMatrix4x3fvEXT(uint program, int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramUniformui64NV(uint program, int location, ulong value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramUniformui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ProgramUniformui64vNV(uint program, int location, int count, ulong* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProgramVertexLimitNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProgramVertexLimitNV(NvGeometryProgram4 target, int limit);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProvokingVertex", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProvokingVertex(ProvokingVertexMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glProvokingVertexEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ProvokingVertexEXT(ExtProvokingVertex mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPushAttrib", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PushAttrib(AttribMask mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPushClientAttrib", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PushClientAttrib(ClientAttribMask mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPushClientAttribDefaultEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PushClientAttribDefaultEXT(ClientAttribMask mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPushMatrix", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PushMatrix();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glPushName", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void PushName(uint name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glQueryCounter", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void QueryCounter(uint id, QueryCounterTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos2d(double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos2dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos2f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos2f(float x, float y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos2fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos2i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos2i(int x, int y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos2iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos2iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos2s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos2s(short x, short y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos2sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos2sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos3d(double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos3dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos3f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos3f(float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos3fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos3i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos3i(int x, int y, int z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos3iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos3iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos3s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos3s(short x, short y, short z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos3sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos3sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos4d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos4d(double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos4dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos4f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos4f(float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos4fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos4i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos4i(int x, int y, int z, int w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos4iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos4iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos4s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RasterPos4s(short x, short y, short z, short w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRasterPos4sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RasterPos4sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReadBuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReadBuffer(ReadBufferMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReadInstrumentsSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReadInstrumentsSGIX(int marker);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReadnPixelsARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReadnPixelsARB(int x, int y, int width, int height, ArbRobustness format, ArbRobustness type, int bufSize, [Out] IntPtr data);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReadPixels", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, [Out] IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRectd", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Rectd(double x1, double y1, double x2, double y2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRectdv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Rectdv(double* v1, double* v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRectf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Rectf(float x1, float y1, float x2, float y2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRectfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Rectfv(float* v1, float* v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRecti", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Recti(int x1, int y1, int x2, int y2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRectiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Rectiv(int* v1, int* v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRects", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Rects(short x1, short y1, short x2, short y2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRectsv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Rectsv(short* v1, short* v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReferencePlaneSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReferencePlaneSGIX(double* equation);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReleaseShaderCompiler", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReleaseShaderCompiler();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRenderbufferStorage", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RenderbufferStorage(RenderbufferTarget target, RenderbufferStorage internalformat, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRenderbufferStorageEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RenderbufferStorageEXT(RenderbufferTarget target, RenderbufferStorage internalformat, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRenderbufferStorageMultisample", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, RenderbufferStorage internalformat, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RenderbufferStorageMultisampleCoverageNV(RenderbufferTarget target, int coverageSamples, int colorSamples, PixelInternalFormat internalformat, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRenderbufferStorageMultisampleEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void RenderbufferStorageMultisampleEXT(ExtFramebufferMultisample target, int samples, ExtFramebufferMultisample internalformat, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRenderMode", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int RenderMode(RenderingMode mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodePointerSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodePointerSUN(SunTriangleList type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeubSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodeubSUN(byte code);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeubvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReplacementCodeubvSUN(byte* code);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiColor3fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodeuiColor3fVertex3fSUN(uint rc, float r, float g, float b, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReplacementCodeuiColor3fVertex3fvSUN(uint* rc, float* c, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodeuiColor4fNormal3fVertex3fSUN(uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(uint* rc, float* c, float* n, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiColor4ubVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodeuiColor4ubVertex3fSUN(uint rc, byte r, byte g, byte b, byte a, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReplacementCodeuiColor4ubVertex3fvSUN(uint* rc, byte* c, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiNormal3fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodeuiNormal3fVertex3fSUN(uint rc, float nx, float ny, float nz, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReplacementCodeuiNormal3fVertex3fvSUN(uint* rc, float* n, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodeuiSUN(uint code);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(uint* rc, float* tc, float* c, float* n, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(uint* rc, float* tc, float* n, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodeuiTexCoord2fVertex3fSUN(uint rc, float s, float t, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReplacementCodeuiTexCoord2fVertex3fvSUN(uint* rc, float* tc, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodeuiVertex3fSUN(uint rc, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuiVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReplacementCodeuiVertex3fvSUN(uint* rc, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeuivSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReplacementCodeuivSUN(uint* code);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeusSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ReplacementCodeusSUN(ushort code);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glReplacementCodeusvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ReplacementCodeusvSUN(ushort* code);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRequestResidentProgramsNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void RequestResidentProgramsNV(int n, uint* programs);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glResetHistogram", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ResetHistogram(HistogramTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glResetHistogramEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ResetHistogramEXT(ExtHistogram target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glResetMinmax", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ResetMinmax(MinmaxTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glResetMinmaxEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ResetMinmaxEXT(ExtHistogram target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glResizeBuffersMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ResizeBuffersMESA();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glResumeTransformFeedback", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ResumeTransformFeedback();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glResumeTransformFeedbackNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ResumeTransformFeedbackNV();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRotated", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Rotated(double angle, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glRotatef", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Rotatef(float angle, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSampleCoverage", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SampleCoverage(float value, bool invert);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSampleCoverageARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SampleCoverageARB(float value, bool invert);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSampleMapATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SampleMapATI(uint dst, uint interp, AtiFragmentShader swizzle);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSampleMaskEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SampleMaskEXT(float value, bool invert);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSampleMaski", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SampleMaski(uint index, uint mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSampleMaskIndexedNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SampleMaskIndexedNV(uint index, uint mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSampleMaskSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SampleMaskSGIS(float value, bool invert);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSamplePatternEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SamplePatternEXT(ExtMultisample pattern);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSamplePatternSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SamplePatternSGIS(SgisMultisample pattern);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSamplerParameterf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SamplerParameterf(uint sampler, SamplerParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSamplerParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SamplerParameterfv(uint sampler, SamplerParameter pname, float* param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSamplerParameteri", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SamplerParameteri(uint sampler, SamplerParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSamplerParameterIiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SamplerParameterIiv(uint sampler, ArbSamplerObjects pname, int* param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSamplerParameterIuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SamplerParameterIuiv(uint sampler, ArbSamplerObjects pname, uint* param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSamplerParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SamplerParameteriv(uint sampler, SamplerParameter pname, int* param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glScaled", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Scaled(double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glScalef", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Scalef(float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glScissor", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Scissor(int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glScissorArrayv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ScissorArrayv(uint first, int count, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glScissorIndexed", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ScissorIndexed(uint index, int left, int bottom, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glScissorIndexedv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ScissorIndexedv(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3b", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3b(sbyte red, sbyte green, sbyte blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3bEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3bEXT(sbyte red, sbyte green, sbyte blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3bv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3bv(sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3bvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3bvEXT(sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3d(double red, double green, double blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3dEXT(double red, double green, double blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3dvEXT(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3f(float red, float green, float blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3fEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3fEXT(float red, float green, float blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3fvEXT(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3i(int red, int green, int blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3iEXT(int red, int green, int blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3ivEXT(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3s(short red, short green, short blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3sEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3sEXT(short red, short green, short blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3svEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3svEXT(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3ub", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3ub(byte red, byte green, byte blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3ubEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3ubEXT(byte red, byte green, byte blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3ubv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3ubv(byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3ubvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3ubvEXT(byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3ui(uint red, uint green, uint blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3uiEXT(uint red, uint green, uint blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3uiv(uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3uivEXT(uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3us", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3us(ushort red, ushort green, ushort blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3usEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColor3usEXT(ushort red, ushort green, ushort blue);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3usv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3usv(ushort* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColor3usvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColor3usvEXT(ushort* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColorFormatNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColorFormatNV(int size, NvVertexBufferUnifiedMemory type, int stride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColorP3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColorP3ui(PackedPointerType type, uint color);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColorP3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SecondaryColorP3uiv(PackedPointerType type, uint* color);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColorPointer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColorPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColorPointerEXT(int size, ColorPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSecondaryColorPointerListIBM", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SecondaryColorPointerListIBM(int size, IbmVertexArrayLists type, int stride, IntPtr pointer, int ptrstride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSelectBuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SelectBuffer(int size, [Out] uint* buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSelectPerfMonitorCountersAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, int numCounters, [Out] uint* counterList);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSeparableFilter2D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SeparableFilter2D(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr row, IntPtr column);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSeparableFilter2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SeparableFilter2DEXT(ExtConvolution target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr row, IntPtr column);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSetFenceAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SetFenceAPPLE(uint fence);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSetFenceNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SetFenceNV(uint fence, NvFence condition);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSetFragmentShaderConstantATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SetFragmentShaderConstantATI(uint dst, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSetInvariantEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SetInvariantEXT(uint id, ExtVertexShader type, IntPtr addr);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSetLocalConstantEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SetLocalConstantEXT(uint id, ExtVertexShader type, IntPtr addr);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glShadeModel", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ShadeModel(ShadingModel mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glShaderBinary", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ShaderBinary(int count, uint* shaders, BinaryFormat binaryformat, IntPtr binary, int length);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glShaderOp1EXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ShaderOp1EXT(ExtVertexShader op, uint res, uint arg1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glShaderOp2EXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ShaderOp2EXT(ExtVertexShader op, uint res, uint arg1, uint arg2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glShaderOp3EXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ShaderOp3EXT(ExtVertexShader op, uint res, uint arg1, uint arg2, uint arg3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glShaderSource", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ShaderSource(uint shader, int count, string[] @string, int* length);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glShaderSourceARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ShaderSourceARB(uint shaderObj, int count, string[] @string, int* length);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSharpenTexFuncSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SharpenTexFuncSGIS(TextureTarget target, int n, float* points);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSpriteParameterfSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SpriteParameterfSGIX(SgixSprite pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSpriteParameterfvSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SpriteParameterfvSGIX(SgixSprite pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSpriteParameteriSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SpriteParameteriSGIX(SgixSprite pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSpriteParameterivSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void SpriteParameterivSGIX(SgixSprite pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStartInstrumentsSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StartInstrumentsSGIX();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStencilClearTagEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StencilClearTagEXT(int stencilTagBits, uint stencilClearTag);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStencilFunc", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StencilFunc(StencilFunction func, int @ref, uint mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StencilFuncSeparate(Version20 face, StencilFunction func, int @ref, uint mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStencilFuncSeparateATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StencilFuncSeparateATI(StencilFunction frontfunc, StencilFunction backfunc, int @ref, uint mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStencilMask", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StencilMask(uint mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StencilMaskSeparate(StencilFace face, uint mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStencilOp", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StencilOpSeparate(StencilFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStencilOpSeparateATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StencilOpSeparateATI(AtiSeparateStencil face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStopInstrumentsSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StopInstrumentsSGIX(int marker);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glStringMarkerGREMEDY", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void StringMarkerGREMEDY(int len, IntPtr @string);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glSwizzleEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void SwizzleEXT(uint res, uint @in, ExtVertexShader outX, ExtVertexShader outY, ExtVertexShader outZ, ExtVertexShader outW);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTagSampleBufferSGIX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TagSampleBufferSGIX();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTangent3bEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Tangent3bEXT(sbyte tx, sbyte ty, sbyte tz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTangent3bvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Tangent3bvEXT(sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTangent3dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Tangent3dEXT(double tx, double ty, double tz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTangent3dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Tangent3dvEXT(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTangent3fEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Tangent3fEXT(float tx, float ty, float tz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTangent3fvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Tangent3fvEXT(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTangent3iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Tangent3iEXT(int tx, int ty, int tz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTangent3ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Tangent3ivEXT(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTangent3sEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Tangent3sEXT(short tx, short ty, short tz);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTangent3svEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Tangent3svEXT(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTangentPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TangentPointerEXT(NormalPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTbufferMask3DFX", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TbufferMask3DFX(uint mask);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTessellationFactorAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TessellationFactorAMD(float factor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTessellationModeAMD", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TessellationModeAMD(AmdVertexShaderTesselator mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTestFenceAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool TestFenceAPPLE(uint fence);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTestFenceNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool TestFenceNV(uint fence);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTestObjectAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool TestObjectAPPLE(AppleFence @object, uint name);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexBuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexBuffer(TextureBufferTarget target, SizedInternalFormat internalformat, uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexBufferARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexBufferARB(TextureTarget target, ArbTextureBufferObject internalformat, uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexBufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexBufferEXT(TextureTarget target, ExtTextureBufferObject internalformat, uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexBumpParameterfvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexBumpParameterfvATI(AtiEnvmapBumpmap pname, float* param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexBumpParameterivATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexBumpParameterivATI(AtiEnvmapBumpmap pname, int* param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord1d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord1d(double s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord1dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord1dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord1f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord1f(float s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord1fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord1fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord1i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord1i(int s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord1iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord1iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord1s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord1s(short s);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord1sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord1sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord2d(double s, double t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord2dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord2f(float s, float t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2fColor3fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord2fColor3fVertex3fvSUN(float* tc, float* c, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord2fColor4fNormal3fVertex3fvSUN(float* tc, float* c, float* n, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2fColor4ubVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord2fColor4ubVertex3fvSUN(float* tc, byte* c, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2fNormal3fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord2fNormal3fVertex3fvSUN(float* tc, float* n, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord2fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2fVertex3fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord2fVertex3fSUN(float s, float t, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2fVertex3fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord2fVertex3fvSUN(float* tc, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord2i(int s, int t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord2iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord2s(short s, short t);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord2sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord2sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord3d(double s, double t, double r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord3dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord3f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord3f(float s, float t, float r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord3fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord3i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord3i(int s, int t, int r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord3iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord3iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord3s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord3s(short s, short t, short r);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord3sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord3sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord4d(double s, double t, double r, double q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord4dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord4f(float s, float t, float r, float q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord4fColor4fNormal3fVertex4fvSUN(float* tc, float* c, float* n, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord4fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4fVertex4fSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4fVertex4fvSUN", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord4fVertex4fvSUN(float* tc, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord4i(int s, int t, int r, int q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord4iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoord4s(short s, short t, short r, short q);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoord4sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoord4sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordFormatNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoordFormatNV(int size, NvVertexBufferUnifiedMemory type, int stride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordP1ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoordP1ui(PackedPointerType type, uint coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordP1uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoordP1uiv(PackedPointerType type, uint* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordP2ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoordP2ui(PackedPointerType type, uint coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordP2uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoordP2uiv(PackedPointerType type, uint* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordP3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoordP3ui(PackedPointerType type, uint coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordP3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoordP3uiv(PackedPointerType type, uint* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordP4ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoordP4ui(PackedPointerType type, uint coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordP4uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexCoordP4uiv(PackedPointerType type, uint* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordPointer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoordPointer(int size, TexCoordPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoordPointerEXT(int size, TexCoordPointerType type, int stride, int count, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordPointerListIBM", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoordPointerListIBM(int size, TexCoordPointerType type, int stride, IntPtr pointer, int ptrstride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexCoordPointervINTEL", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexCoordPointervINTEL(int size, VertexPointerType type, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexEnvf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexEnvfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexEnvi", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexEnviv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexFilterFuncSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexFilterFuncSGIS(TextureTarget target, SgisTextureFilter4 filter, int n, float* weights);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexGend", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexGend(TextureCoordName coord, TextureGenParameter pname, double param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexGendv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexGendv(TextureCoordName coord, TextureGenParameter pname, double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexGenf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexGenf(TextureCoordName coord, TextureGenParameter pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexGenfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexGenfv(TextureCoordName coord, TextureGenParameter pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexGeni", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexGeni(TextureCoordName coord, TextureGenParameter pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexGeniv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexGeniv(TextureCoordName coord, TextureGenParameter pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexImage1D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexImage1D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexImage2D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexImage2DMultisample", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexImage2DMultisample(TextureTargetMultisample target, int samples, PixelInternalFormat internalformat, int width, int height, bool fixedsamplelocations);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexImage3D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexImage3D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexImage3DEXT(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexImage3DMultisample", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexImage3DMultisample(TextureTargetMultisample target, int samples, PixelInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexImage4DSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexImage4DSGIS(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexParameterf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexParameterf(TextureTarget target, TextureParameterName pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexParameterfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexParameterfv(TextureTarget target, TextureParameterName pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexParameteri", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexParameteri(TextureTarget target, TextureParameterName pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexParameterIiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexParameterIiv(TextureTarget target, TextureParameterName pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexParameterIivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexParameterIuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexParameterIuivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexParameteriv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TexParameteriv(TextureTarget target, TextureParameterName pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexRenderbufferNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexRenderbufferNV(TextureTarget target, uint renderbuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexSubImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexSubImage1DEXT(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexSubImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexSubImage2DEXT(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexSubImage3D", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexSubImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexSubImage3DEXT(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTexSubImage4DSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TexSubImage4DSGIS(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureBarrierNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureBarrierNV();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureBufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureBufferEXT(uint texture, TextureTarget target, ExtDirectStateAccess internalformat, uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureColorMaskSGIS", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureImage1DEXT(uint texture, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureImage2DEXT(uint texture, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureImage3DEXT(uint texture, TextureTarget target, int level, ExtDirectStateAccess internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureLightEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureLightEXT(ExtLightTexture pname);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureMaterialEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureMaterialEXT(MaterialFace face, MaterialParameter mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureNormalEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureNormalEXT(ExtTexturePerturbNormal mode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureParameterfEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureParameterfEXT(uint texture, TextureTarget target, TextureParameterName pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureParameterfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TextureParameterfvEXT(uint texture, TextureTarget target, TextureParameterName pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureParameteriEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureParameteriEXT(uint texture, TextureTarget target, TextureParameterName pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureParameterIivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TextureParameterIivEXT(uint texture, TextureTarget target, TextureParameterName pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureParameterIuivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TextureParameterIuivEXT(uint texture, TextureTarget target, TextureParameterName pname, uint* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureParameterivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TextureParameterivEXT(uint texture, TextureTarget target, TextureParameterName pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureRangeAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureRangeAPPLE(AppleTextureRange target, int length, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureRenderbufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureRenderbufferEXT(uint texture, TextureTarget target, uint renderbuffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureSubImage1DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureSubImage1DEXT(uint texture, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureSubImage2DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureSubImage2DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTextureSubImage3DEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TextureSubImage3DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTrackMatrixNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TrackMatrixNV(AssemblyProgramTargetArb target, uint address, NvVertexProgram matrix, NvVertexProgram transform);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTransformFeedbackAttribsNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TransformFeedbackAttribsNV(uint count, int* attribs, NvTransformFeedback bufferMode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTransformFeedbackStreamAttribsNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TransformFeedbackStreamAttribsNV(int count, int* attribs, int nbuffers, int* bufstreams, NvTransformFeedback bufferMode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTransformFeedbackVaryings", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TransformFeedbackVaryings(uint program, int count, string[] varyings, TransformFeedbackMode bufferMode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTransformFeedbackVaryingsEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void TransformFeedbackVaryingsEXT(uint program, int count, string[] varyings, ExtTransformFeedback bufferMode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTransformFeedbackVaryingsNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void TransformFeedbackVaryingsNV(uint program, int count, int* locations, NvTransformFeedback bufferMode);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTranslated", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Translated(double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glTranslatef", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Translatef(float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform1d(int location, double x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform1dv(int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform1f(int location, float v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform1fARB(int location, float v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform1fv(int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform1fvARB(int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform1i(int location, int v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform1i64NV(int location, long x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform1i64vNV(int location, int count, long* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1iARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform1iARB(int location, int v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform1iv(int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1ivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform1ivARB(int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform1ui(int location, uint v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform1ui64NV(int location, ulong x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform1ui64vNV(int location, int count, ulong* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform1uiEXT(int location, uint v0);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform1uiv(int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform1uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform1uivEXT(int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform2d(int location, double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform2dv(int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform2f(int location, float v0, float v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform2fARB(int location, float v0, float v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform2fv(int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform2fvARB(int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform2i(int location, int v0, int v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform2i64NV(int location, long x, long y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform2i64vNV(int location, int count, long* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2iARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform2iARB(int location, int v0, int v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform2iv(int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2ivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform2ivARB(int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform2ui(int location, uint v0, uint v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform2ui64NV(int location, ulong x, ulong y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform2ui64vNV(int location, int count, ulong* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform2uiEXT(int location, uint v0, uint v1);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform2uiv(int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform2uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform2uivEXT(int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform3d(int location, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform3dv(int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform3f(int location, float v0, float v1, float v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform3fARB(int location, float v0, float v1, float v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform3fv(int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform3fvARB(int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform3i(int location, int v0, int v1, int v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform3i64NV(int location, long x, long y, long z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform3i64vNV(int location, int count, long* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3iARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform3iARB(int location, int v0, int v1, int v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform3iv(int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3ivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform3ivARB(int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform3ui(int location, uint v0, uint v1, uint v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform3ui64NV(int location, ulong x, ulong y, ulong z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform3ui64vNV(int location, int count, ulong* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform3uiEXT(int location, uint v0, uint v1, uint v2);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform3uiv(int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform3uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform3uivEXT(int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform4d(int location, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform4dv(int location, int count, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform4f(int location, float v0, float v1, float v2, float v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform4fARB(int location, float v0, float v1, float v2, float v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform4fv(int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform4fvARB(int location, int count, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform4i(int location, int v0, int v1, int v2, int v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform4i64NV(int location, long x, long y, long z, long w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform4i64vNV(int location, int count, long* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4iARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform4iARB(int location, int v0, int v1, int v2, int v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform4iv(int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4ivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform4ivARB(int location, int count, int* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform4ui64vNV(int location, int count, ulong* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniform4uiEXT(int location, uint v0, uint v1, uint v2, uint v3);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform4uiv(int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniform4uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniform4uivEXT(int location, int count, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformBlockBinding", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformBufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void UniformBufferEXT(uint program, int location, uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix2dv(int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix2fv(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix2fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix2fvARB(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix2x3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix2x3dv(int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix2x3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix2x3fv(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix2x4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix2x4dv(int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix2x4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix2x4fv(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix3dv(int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix3fv(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix3fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix3fvARB(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix3x2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix3x2dv(int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix3x2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix3x2fv(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix3x4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix3x4dv(int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix3x4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix3x4fv(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix4dv(int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix4fv(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix4fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix4fvARB(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix4x2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix4x2dv(int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix4x2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix4x2fv(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix4x3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix4x3dv(int location, int count, bool transpose, double* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformMatrix4x3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformMatrix4x3fv(int location, int count, bool transpose, float* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformSubroutinesuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void UniformSubroutinesuiv(ShaderType shadertype, int count, uint* indices);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Uniformui64NV(int location, ulong value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUniformui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Uniformui64vNV(int location, int count, ulong* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUnlockArraysEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void UnlockArraysEXT();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUnmapBuffer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool UnmapBuffer(BufferTarget target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUnmapBufferARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool UnmapBufferARB(BufferTargetArb target);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUnmapNamedBufferEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool UnmapNamedBufferEXT(uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUnmapObjectBufferATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void UnmapObjectBufferATI(uint buffer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUpdateObjectBufferATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void UpdateObjectBufferATI(uint buffer, uint offset, int size, IntPtr pointer, AtiVertexArrayObject preserve);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUseProgram", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void UseProgram(uint program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUseProgramObjectARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void UseProgramObjectARB(uint programObj);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUseProgramStages", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void UseProgramStages(uint pipeline, ProgramStageMask stages, uint program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glUseShaderProgramEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void UseShaderProgramEXT(ExtSeparateShaderObjects type, uint program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glValidateProgram", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ValidateProgram(uint program);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glValidateProgramARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ValidateProgramARB(uint programObj);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glValidateProgramPipeline", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ValidateProgramPipeline(uint pipeline);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVariantArrayObjectATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VariantArrayObjectATI(uint id, AtiVertexArrayObject type, int stride, uint buffer, uint offset);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVariantbvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VariantbvEXT(uint id, sbyte* addr);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVariantdvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VariantdvEXT(uint id, double* addr);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVariantfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VariantfvEXT(uint id, float* addr);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVariantivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VariantivEXT(uint id, int* addr);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVariantPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VariantPointerEXT(uint id, ExtVertexShader type, uint stride, IntPtr addr);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVariantsvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VariantsvEXT(uint id, short* addr);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVariantubvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VariantubvEXT(uint id, byte* addr);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVariantuivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VariantuivEXT(uint id, uint* addr);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVariantusvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VariantusvEXT(uint id, ushort* addr);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVDPAUFiniNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VDPAUFiniNV();

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVDPAUGetSurfaceivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VDPAUGetSurfaceivNV(IntPtr surface, NvVdpauInterop pname, int bufSize, [Out] int* length, [Out] int* values);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVDPAUInitNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVDPAUIsSurfaceNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VDPAUIsSurfaceNV(IntPtr surface);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVDPAUMapSurfacesNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VDPAUMapSurfacesNV(int numSurfaces, IntPtr* surfaces);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVDPAURegisterOutputSurfaceNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern IntPtr VDPAURegisterOutputSurfaceNV([Out] IntPtr vdpSurface, NvVdpauInterop target, int numTextureNames, uint* textureNames);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVDPAURegisterVideoSurfaceNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern IntPtr VDPAURegisterVideoSurfaceNV([Out] IntPtr vdpSurface, NvVdpauInterop target, int numTextureNames, uint* textureNames);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVDPAUSurfaceAccessNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VDPAUSurfaceAccessNV(IntPtr surface, NvVdpauInterop access);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVDPAUUnmapSurfacesNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VDPAUUnmapSurfacesNV(int numSurface, IntPtr* surfaces);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVDPAUUnregisterSurfaceNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VDPAUUnregisterSurfaceNV(IntPtr surface);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex2d(double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex2dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex2f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex2f(float x, float y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex2fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex2i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex2i(int x, int y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex2iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex2iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex2s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex2s(short x, short y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex2sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex2sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex3d(double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex3dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex3f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex3f(float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex3fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex3i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex3i(int x, int y, int z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex3iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex3iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex3s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex3s(short x, short y, short z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex3sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex3sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex4d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex4d(double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex4dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex4f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex4f(float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex4fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex4i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex4i(int x, int y, int z, int w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex4iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex4iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex4s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Vertex4s(short x, short y, short z, short w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertex4sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void Vertex4sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexArrayParameteriAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexArrayParameteriAPPLE(AppleVertexArrayRange pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexArrayRangeAPPLE", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexArrayRangeAPPLE(int length, [Out] IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexArrayRangeNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexArrayRangeNV(int length, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexArrayVertexAttribLOffsetEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexArrayVertexAttribLOffsetEXT(uint vaobj, uint buffer, uint index, int size, ExtVertexAttrib64bit type, int stride, IntPtr offset);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib1d(uint index, double x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib1dARB(uint index, double x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1dNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib1dNV(uint index, double x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib1dv(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib1dvARB(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1dvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib1dvNV(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib1f(uint index, float x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib1fARB(uint index, float x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1fNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib1fNV(uint index, float x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib1fv(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib1fvARB(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1fvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib1fvNV(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib1s(uint index, short x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1sARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib1sARB(uint index, short x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1sNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib1sNV(uint index, short x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib1sv(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1svARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib1svARB(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib1svNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib1svNV(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib2d(uint index, double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib2dARB(uint index, double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2dNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib2dNV(uint index, double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib2dv(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib2dvARB(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2dvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib2dvNV(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib2f(uint index, float x, float y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib2fARB(uint index, float x, float y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2fNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib2fNV(uint index, float x, float y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib2fv(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib2fvARB(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2fvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib2fvNV(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib2s(uint index, short x, short y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2sARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib2sARB(uint index, short x, short y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2sNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib2sNV(uint index, short x, short y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib2sv(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2svARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib2svARB(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib2svNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib2svNV(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib3d(uint index, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib3dARB(uint index, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3dNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib3dNV(uint index, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib3dv(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib3dvARB(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3dvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib3dvNV(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib3f(uint index, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib3fARB(uint index, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3fNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib3fNV(uint index, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib3fv(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib3fvARB(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3fvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib3fvNV(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib3s(uint index, short x, short y, short z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3sARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib3sARB(uint index, short x, short y, short z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3sNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib3sNV(uint index, short x, short y, short z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib3sv(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3svARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib3svARB(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib3svNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib3svNV(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4bv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4bv(uint index, sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4bvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4bvARB(uint index, sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4d(uint index, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4dARB(uint index, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4dNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4dNV(uint index, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4dv(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4dvARB(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4dvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4dvNV(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4f(uint index, float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4fARB(uint index, float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4fNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4fNV(uint index, float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4fv(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4fvARB(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4fvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4fvNV(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4iv(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4ivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4ivARB(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4Nbv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4Nbv(uint index, sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4NbvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4NbvARB(uint index, sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4Niv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4Niv(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4NivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4NivARB(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4Nsv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4Nsv(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4NsvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4NsvARB(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4Nub", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4NubARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4Nubv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4Nubv(uint index, byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4NubvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4NubvARB(uint index, byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4Nuiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4Nuiv(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4NuivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4NuivARB(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4Nusv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4Nusv(uint index, ushort* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4NusvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4NusvARB(uint index, ushort* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4s(uint index, short x, short y, short z, short w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4sARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4sARB(uint index, short x, short y, short z, short w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4sNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4sNV(uint index, short x, short y, short z, short w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4sv(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4svARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4svARB(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4svNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4svNV(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4ubNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttrib4ubNV(uint index, byte x, byte y, byte z, byte w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4ubv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4ubv(uint index, byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4ubvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4ubvARB(uint index, byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4ubvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4ubvNV(uint index, byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4uiv(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4uivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4uivARB(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4usv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4usv(uint index, ushort* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttrib4usvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttrib4usvARB(uint index, ushort* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribArrayObjectATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribArrayObjectATI(uint index, int size, AtiVertexAttribArrayObject type, bool normalized, int stride, uint buffer, uint offset);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribDivisor", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribDivisor(uint index, uint divisor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribDivisorARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribDivisorARB(uint index, uint divisor);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribFormatNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribFormatNV(uint index, int size, NvVertexBufferUnifiedMemory type, bool normalized, int stride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI1i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI1i(uint index, int x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI1iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI1iEXT(uint index, int x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI1iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI1iv(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI1ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI1ivEXT(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI1ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI1ui(uint index, uint x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI1uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI1uiEXT(uint index, uint x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI1uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI1uiv(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI1uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI1uivEXT(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI2i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI2i(uint index, int x, int y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI2iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI2iEXT(uint index, int x, int y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI2iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI2iv(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI2ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI2ivEXT(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI2ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI2ui(uint index, uint x, uint y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI2uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI2uiEXT(uint index, uint x, uint y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI2uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI2uiv(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI2uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI2uivEXT(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI3i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI3i(uint index, int x, int y, int z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI3iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI3iEXT(uint index, int x, int y, int z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI3iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI3iv(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI3ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI3ivEXT(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI3ui(uint index, uint x, uint y, uint z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI3uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI3uiEXT(uint index, uint x, uint y, uint z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI3uiv(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI3uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI3uivEXT(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4bv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4bv(uint index, sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4bvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4bvEXT(uint index, sbyte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI4i(uint index, int x, int y, int z, int w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4iEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI4iEXT(uint index, int x, int y, int z, int w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4iv(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4ivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4ivEXT(uint index, int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4sv(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4svEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4svEXT(uint index, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4ubv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4ubv(uint index, byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4ubvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4ubvEXT(uint index, byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4uiEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribI4uiEXT(uint index, uint x, uint y, uint z, uint w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4uiv(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4uivEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4uivEXT(uint index, uint* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4usv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4usv(uint index, ushort* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribI4usvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribI4usvEXT(uint index, ushort* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribIFormatNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribIFormatNV(uint index, int size, NvVertexBufferUnifiedMemory type, int stride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribIPointer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribIPointer(uint index, int size, VertexAttribIPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribIPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribIPointerEXT(uint index, int size, NvVertexProgram4 type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL1d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL1d(uint index, double x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL1dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL1dEXT(uint index, double x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL1dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL1dv(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL1dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL1dvEXT(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL1i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL1i64NV(uint index, long x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL1i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL1i64vNV(uint index, long* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL1ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL1ui64NV(uint index, ulong x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL1ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL1ui64vNV(uint index, ulong* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL2d(uint index, double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL2dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL2dEXT(uint index, double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL2dv(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL2dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL2dvEXT(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL2i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL2i64NV(uint index, long x, long y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL2i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL2i64vNV(uint index, long* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL2ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL2ui64NV(uint index, ulong x, ulong y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL2ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL2ui64vNV(uint index, ulong* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL3d(uint index, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL3dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL3dEXT(uint index, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL3dv(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL3dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL3dvEXT(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL3i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL3i64NV(uint index, long x, long y, long z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL3i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL3i64vNV(uint index, long* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL3ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL3ui64NV(uint index, ulong x, ulong y, ulong z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL3ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL3ui64vNV(uint index, ulong* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL4d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL4d(uint index, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL4dEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL4dEXT(uint index, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL4dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL4dv(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL4dvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL4dvEXT(uint index, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL4i64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL4i64NV(uint index, long x, long y, long z, long w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL4i64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL4i64vNV(uint index, long* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL4ui64NV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribL4ui64NV(uint index, ulong x, ulong y, ulong z, ulong w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribL4ui64vNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribL4ui64vNV(uint index, ulong* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribLFormatNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribLFormatNV(uint index, int size, NvVertexAttribInteger64bit type, int stride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribLPointer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribLPointer(uint index, int size, VertexAttribDPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribLPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribLPointerEXT(uint index, int size, ExtVertexAttrib64bit type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribP1ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribP1ui(uint index, PackedPointerType type, bool normalized, uint value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribP1uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribP1uiv(uint index, PackedPointerType type, bool normalized, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribP2ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribP2ui(uint index, PackedPointerType type, bool normalized, uint value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribP2uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribP2uiv(uint index, PackedPointerType type, bool normalized, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribP3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribP3ui(uint index, PackedPointerType type, bool normalized, uint value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribP3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribP3uiv(uint index, PackedPointerType type, bool normalized, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribP4ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribP4ui(uint index, PackedPointerType type, bool normalized, uint value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribP4uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribP4uiv(uint index, PackedPointerType type, bool normalized, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribPointerARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribPointerARB(uint index, int size, VertexAttribPointerTypeArb type, bool normalized, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribPointerNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexAttribPointerNV(uint index, int fsize, VertexAttribParameterArb type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs1dvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs1dvNV(uint index, int count, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs1fvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs1fvNV(uint index, int count, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs1svNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs1svNV(uint index, int count, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs2dvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs2dvNV(uint index, int count, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs2fvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs2fvNV(uint index, int count, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs2svNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs2svNV(uint index, int count, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs3dvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs3dvNV(uint index, int count, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs3fvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs3fvNV(uint index, int count, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs3svNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs3svNV(uint index, int count, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs4dvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs4dvNV(uint index, int count, double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs4fvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs4fvNV(uint index, int count, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs4svNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs4svNV(uint index, int count, short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexAttribs4ubvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexAttribs4ubvNV(uint index, int count, byte* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexBlendARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexBlendARB(int count);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexBlendEnvfATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexBlendEnvfATI(AtiVertexStreams pname, float param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexBlendEnviATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexBlendEnviATI(AtiVertexStreams pname, int param);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexFormatNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexFormatNV(int size, NvVertexBufferUnifiedMemory type, int stride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexP2ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexP2ui(PackedPointerType type, uint value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexP2uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexP2uiv(PackedPointerType type, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexP3ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexP3ui(PackedPointerType type, uint value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexP3uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexP3uiv(PackedPointerType type, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexP4ui", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexP4ui(PackedPointerType type, uint value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexP4uiv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexP4uiv(PackedPointerType type, uint* value);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexPointer", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexPointer(int size, VertexPointerType type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexPointerEXT(int size, VertexPointerType type, int stride, int count, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexPointerListIBM", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexPointerListIBM(int size, VertexPointerType type, int stride, IntPtr pointer, int ptrstride);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexPointervINTEL", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexPointervINTEL(int size, VertexPointerType type, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream1dATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream1dATI(AtiVertexStreams stream, double x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream1dvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream1dvATI(AtiVertexStreams stream, double* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream1fATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream1fATI(AtiVertexStreams stream, float x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream1fvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream1fvATI(AtiVertexStreams stream, float* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream1iATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream1iATI(AtiVertexStreams stream, int x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream1ivATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream1ivATI(AtiVertexStreams stream, int* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream1sATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream1sATI(AtiVertexStreams stream, short x);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream1svATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream1svATI(AtiVertexStreams stream, short* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream2dATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream2dATI(AtiVertexStreams stream, double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream2dvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream2dvATI(AtiVertexStreams stream, double* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream2fATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream2fATI(AtiVertexStreams stream, float x, float y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream2fvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream2fvATI(AtiVertexStreams stream, float* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream2iATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream2iATI(AtiVertexStreams stream, int x, int y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream2ivATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream2ivATI(AtiVertexStreams stream, int* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream2sATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream2sATI(AtiVertexStreams stream, short x, short y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream2svATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream2svATI(AtiVertexStreams stream, short* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream3dATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream3dATI(AtiVertexStreams stream, double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream3dvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream3dvATI(AtiVertexStreams stream, double* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream3fATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream3fATI(AtiVertexStreams stream, float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream3fvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream3fvATI(AtiVertexStreams stream, float* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream3iATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream3iATI(AtiVertexStreams stream, int x, int y, int z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream3ivATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream3ivATI(AtiVertexStreams stream, int* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream3sATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream3sATI(AtiVertexStreams stream, short x, short y, short z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream3svATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream3svATI(AtiVertexStreams stream, short* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream4dATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream4dATI(AtiVertexStreams stream, double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream4dvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream4dvATI(AtiVertexStreams stream, double* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream4fATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream4fATI(AtiVertexStreams stream, float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream4fvATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream4fvATI(AtiVertexStreams stream, float* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream4iATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream4iATI(AtiVertexStreams stream, int x, int y, int z, int w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream4ivATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream4ivATI(AtiVertexStreams stream, int* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream4sATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexStream4sATI(AtiVertexStreams stream, short x, short y, short z, short w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexStream4svATI", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexStream4svATI(AtiVertexStreams stream, short* coords);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexWeightfEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexWeightfEXT(float weight);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexWeightfvEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VertexWeightfvEXT(float* weight);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVertexWeightPointerEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void VertexWeightPointerEXT(int size, ExtVertexWeighting type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVideoCaptureNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern NvVideoCapture VideoCaptureNV(uint video_capture_slot, [Out] uint* sequence_num, [Out] ulong* capture_time);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVideoCaptureStreamParameterdvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VideoCaptureStreamParameterdvNV(uint video_capture_slot, uint stream, NvVideoCapture pname, double* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVideoCaptureStreamParameterfvNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VideoCaptureStreamParameterfvNV(uint video_capture_slot, uint stream, NvVideoCapture pname, float* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glVideoCaptureStreamParameterivNV", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void VideoCaptureStreamParameterivNV(uint video_capture_slot, uint stream, NvVideoCapture pname, int* @params);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glViewport", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void Viewport(int x, int y, int width, int height);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glViewportArrayv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ViewportArrayv(uint first, int count, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glViewportIndexedf", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void ViewportIndexedf(uint index, float x, float y, float w, float h);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glViewportIndexedfv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void ViewportIndexedfv(uint index, float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWaitSync", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WaitSync(IntPtr sync, uint flags, ulong timeout);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWeightbvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WeightbvARB(int size, sbyte* weights);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWeightdvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WeightdvARB(int size, double* weights);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWeightfvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WeightfvARB(int size, float* weights);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWeightivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WeightivARB(int size, int* weights);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWeightPointerARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WeightPointerARB(int size, ArbVertexBlend type, int stride, IntPtr pointer);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWeightsvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WeightsvARB(int size, short* weights);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWeightubvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WeightubvARB(int size, byte* weights);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWeightuivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WeightuivARB(int size, uint* weights);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWeightusvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WeightusvARB(int size, ushort* weights);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2d(double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2dARB(double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos2dMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2dMESA(double x, double y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2dvARB(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos2dvMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2dvMESA(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2f(float x, float y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2fARB(float x, float y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos2fMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2fMESA(float x, float y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2fvARB(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos2fvMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2fvMESA(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2i(int x, int y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2iARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2iARB(int x, int y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos2iMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2iMESA(int x, int y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2ivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2ivARB(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos2ivMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2ivMESA(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2s(short x, short y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2sARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2sARB(short x, short y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos2sMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos2sMESA(short x, short y);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos2svARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2svARB(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos2svMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos2svMESA(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3d", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3d(double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3dARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3dARB(double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos3dMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3dMESA(double x, double y, double z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3dv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3dv(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3dvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3dvARB(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos3dvMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3dvMESA(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3f", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3f(float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3fARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3fARB(float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos3fMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3fMESA(float x, float y, float z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3fv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3fv(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3fvARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3fvARB(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos3fvMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3fvMESA(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3i", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3i(int x, int y, int z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3iARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3iARB(int x, int y, int z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos3iMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3iMESA(int x, int y, int z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3iv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3iv(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3ivARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3ivARB(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos3ivMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3ivMESA(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3s", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3s(short x, short y, short z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3sARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3sARB(short x, short y, short z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos3sMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos3sMESA(short x, short y, short z);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3sv", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3sv(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWindowPos3svARB", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3svARB(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos3svMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos3svMESA(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos4dMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos4dMESA(double x, double y, double z, double w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos4dvMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos4dvMESA(double* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos4fMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos4fMESA(float x, float y, float z, float w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos4fvMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos4fvMESA(float* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos4iMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos4iMESA(int x, int y, int z, int w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos4ivMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos4ivMESA(int* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos4sMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WindowPos4sMESA(short x, short y, short z, short w);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", CharSet = CharSet.Auto, EntryPoint = "glWindowPos4svMESA")]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern void WindowPos4svMESA(short* v);

		[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL", EntryPoint = "glWriteMaskEXT", ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void WriteMaskEXT(uint res, uint @in, ExtVertexShader outX, ExtVertexShader outY, ExtVertexShader outZ, ExtVertexShader outW);
	}

	internal const string Library = "/System/Library/Frameworks/OpenGL.framework/OpenGL";

	private static readonly object sync_root;

	protected object SyncRoot => sync_root;

	public static void Accum(AccumOp op, float value)
	{
		Core.Accum(op, value);
	}

	public static void ActiveTexture(TextureUnit texture)
	{
		Core.ActiveTexture(texture);
	}

	public static void AlphaFunc(AlphaFunction func, float @ref)
	{
		Core.AlphaFunc(func, @ref);
	}

	public unsafe static bool AreTexturesResident(int n, int[] textures, [Out] bool[] residences)
	{
		fixed (int* textures2 = textures)
		{
			fixed (bool* residences2 = residences)
			{
				return Core.AreTexturesResident(n, (uint*)textures2, residences2);
			}
		}
	}

	public static void ArrayElement(int i)
	{
		Core.ArrayElement(i);
	}

	public static void AttachShader(int program, int shader)
	{
		Core.AttachShader((uint)program, (uint)shader);
	}

	[CLSCompliant(false)]
	public static void AttachShader(uint program, uint shader)
	{
		Core.AttachShader(program, shader);
	}

	public static void Begin(BeginMode mode)
	{
		Core.Begin(mode);
	}

	public static void BeginQuery(QueryTarget target, int id)
	{
		Core.BeginQuery(target, (uint)id);
	}

	[CLSCompliant(false)]
	public static void BeginQuery(QueryTarget target, uint id)
	{
		Core.BeginQuery(target, id);
	}

	public static void BindAttribLocation(int program, int index, string name)
	{
		Core.BindAttribLocation((uint)program, (uint)index, name);
	}

	[CLSCompliant(false)]
	public static void BindAttribLocation(uint program, uint index, string name)
	{
		Core.BindAttribLocation(program, index, name);
	}

	public static void BindBuffer(BufferTarget target, int buffer)
	{
		Core.BindBuffer(target, (uint)buffer);
	}

	[CLSCompliant(false)]
	public static void BindBuffer(BufferTarget target, uint buffer)
	{
		Core.BindBuffer(target, buffer);
	}

	public static void BindTexture(TextureTarget target, int texture)
	{
		Core.BindTexture(target, (uint)texture);
	}

	[CLSCompliant(false)]
	public static void BindTexture(TextureTarget target, uint texture)
	{
		Core.BindTexture(target, texture);
	}

	public unsafe static void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap)
	{
		fixed (byte* bitmap2 = bitmap)
		{
			Core.Bitmap(width, height, xorig, yorig, xmove, ymove, bitmap2);
		}
	}

	public unsafe static void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, ref byte bitmap)
	{
		fixed (byte* bitmap2 = &bitmap)
		{
			Core.Bitmap(width, height, xorig, yorig, xmove, ymove, bitmap2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap)
	{
		Core.Bitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
	}

	public static void BlendColor(float red, float green, float blue, float alpha)
	{
		Core.BlendColor(red, green, blue, alpha);
	}

	public static void BlendEquation(BlendEquationMode mode)
	{
		Core.BlendEquation(mode);
	}

	public static void BlendEquationSeparate(BlendEquationMode modeRGB, BlendEquationMode modeAlpha)
	{
		Core.BlendEquationSeparate(modeRGB, modeAlpha);
	}

	public static void BlendFunc(BlendingFactorSrc sfactor, BlendingFactorDest dfactor)
	{
		Core.BlendFunc(sfactor, dfactor);
	}

	public static void BlendFuncSeparate(BlendingFactorSrc sfactorRGB, BlendingFactorDest dfactorRGB, BlendingFactorSrc sfactorAlpha, BlendingFactorDest dfactorAlpha)
	{
		Core.BlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
	}

	public static void BufferData(BufferTarget target, IntPtr size, IntPtr data, BufferUsageHint usage)
	{
		Core.BufferData(target, size, data, usage);
	}

	public static void BufferData<T2>(BufferTarget target, IntPtr size, [In][Out] T2[] data, BufferUsageHint usage) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.BufferData(target, size, gCHandle.AddrOfPinnedObject(), usage);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void BufferData<T2>(BufferTarget target, IntPtr size, [In][Out] T2[,] data, BufferUsageHint usage) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.BufferData(target, size, gCHandle.AddrOfPinnedObject(), usage);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void BufferData<T2>(BufferTarget target, IntPtr size, [In][Out] T2[,,] data, BufferUsageHint usage) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.BufferData(target, size, gCHandle.AddrOfPinnedObject(), usage);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void BufferData<T2>(BufferTarget target, IntPtr size, [In][Out] ref T2 data, BufferUsageHint usage) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.BufferData(target, size, gCHandle.AddrOfPinnedObject(), usage);
			data = (T2)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void BufferSubData(BufferTarget target, IntPtr offset, IntPtr size, IntPtr data)
	{
		Core.BufferSubData(target, offset, size, data);
	}

	public static void BufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, [In][Out] T3[] data) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.BufferSubData(target, offset, size, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void BufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, [In][Out] T3[,] data) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.BufferSubData(target, offset, size, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void BufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, [In][Out] T3[,,] data) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.BufferSubData(target, offset, size, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void BufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, [In][Out] ref T3 data) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.BufferSubData(target, offset, size, gCHandle.AddrOfPinnedObject());
			data = (T3)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CallList(int list)
	{
		Core.CallList((uint)list);
	}

	public static void CallList(uint list)
	{
		Core.CallList(list);
	}

	public static void CallLists(int n, ListNameType type, IntPtr lists)
	{
		Core.CallLists(n, type, lists);
	}

	public static void CallLists<T2>(int n, ListNameType type, [In][Out] T2[] lists) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(lists, GCHandleType.Pinned);
		try
		{
			Core.CallLists(n, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CallLists<T2>(int n, ListNameType type, [In][Out] T2[,] lists) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(lists, GCHandleType.Pinned);
		try
		{
			Core.CallLists(n, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CallLists<T2>(int n, ListNameType type, [In][Out] T2[,,] lists) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(lists, GCHandleType.Pinned);
		try
		{
			Core.CallLists(n, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CallLists<T2>(int n, ListNameType type, [In][Out] ref T2 lists) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(lists, GCHandleType.Pinned);
		try
		{
			Core.CallLists(n, type, gCHandle.AddrOfPinnedObject());
			lists = (T2)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void Clear(ClearBufferMask mask)
	{
		Core.Clear(mask);
	}

	public static void ClearAccum(float red, float green, float blue, float alpha)
	{
		Core.ClearAccum(red, green, blue, alpha);
	}

	public static void ClearColor(float red, float green, float blue, float alpha)
	{
		Core.ClearColor(red, green, blue, alpha);
	}

	public static void ClearDepth(double depth)
	{
		Core.ClearDepth(depth);
	}

	public static void ClearIndex(float c)
	{
		Core.ClearIndex(c);
	}

	public static void ClearStencil(int s)
	{
		Core.ClearStencil(s);
	}

	public static void ClientActiveTexture(TextureUnit texture)
	{
		Core.ClientActiveTexture(texture);
	}

	public unsafe static void ClipPlane(ClipPlaneName plane, double[] equation)
	{
		fixed (double* equation2 = equation)
		{
			Core.ClipPlane(plane, equation2);
		}
	}

	public unsafe static void ClipPlane(ClipPlaneName plane, ref double equation)
	{
		fixed (double* equation2 = &equation)
		{
			Core.ClipPlane(plane, equation2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void ClipPlane(ClipPlaneName plane, double* equation)
	{
		Core.ClipPlane(plane, equation);
	}

	[CLSCompliant(false)]
	public static void Color3(sbyte red, sbyte green, sbyte blue)
	{
		Core.Color3b(red, green, blue);
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(sbyte[] v)
	{
		fixed (sbyte* v2 = v)
		{
			Core.Color3bv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(ref sbyte v)
	{
		fixed (sbyte* v2 = &v)
		{
			Core.Color3bv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(sbyte* v)
	{
		Core.Color3bv(v);
	}

	public static void Color3(double red, double green, double blue)
	{
		Core.Color3d(red, green, blue);
	}

	public unsafe static void Color3(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.Color3dv(v2);
		}
	}

	public unsafe static void Color3(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.Color3dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(double* v)
	{
		Core.Color3dv(v);
	}

	public static void Color3(float red, float green, float blue)
	{
		Core.Color3f(red, green, blue);
	}

	public unsafe static void Color3(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.Color3fv(v2);
		}
	}

	public unsafe static void Color3(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.Color3fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(float* v)
	{
		Core.Color3fv(v);
	}

	public static void Color3(int red, int green, int blue)
	{
		Core.Color3i(red, green, blue);
	}

	public unsafe static void Color3(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.Color3iv(v2);
		}
	}

	public unsafe static void Color3(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.Color3iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(int* v)
	{
		Core.Color3iv(v);
	}

	public static void Color3(short red, short green, short blue)
	{
		Core.Color3s(red, green, blue);
	}

	public unsafe static void Color3(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.Color3sv(v2);
		}
	}

	public unsafe static void Color3(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.Color3sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(short* v)
	{
		Core.Color3sv(v);
	}

	public static void Color3(byte red, byte green, byte blue)
	{
		Core.Color3ub(red, green, blue);
	}

	public unsafe static void Color3(byte[] v)
	{
		fixed (byte* v2 = v)
		{
			Core.Color3ubv(v2);
		}
	}

	public unsafe static void Color3(ref byte v)
	{
		fixed (byte* v2 = &v)
		{
			Core.Color3ubv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(byte* v)
	{
		Core.Color3ubv(v);
	}

	[CLSCompliant(false)]
	public static void Color3(uint red, uint green, uint blue)
	{
		Core.Color3ui(red, green, blue);
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(uint[] v)
	{
		fixed (uint* v2 = v)
		{
			Core.Color3uiv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(ref uint v)
	{
		fixed (uint* v2 = &v)
		{
			Core.Color3uiv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(uint* v)
	{
		Core.Color3uiv(v);
	}

	[CLSCompliant(false)]
	public static void Color3(ushort red, ushort green, ushort blue)
	{
		Core.Color3us(red, green, blue);
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(ushort[] v)
	{
		fixed (ushort* v2 = v)
		{
			Core.Color3usv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(ref ushort v)
	{
		fixed (ushort* v2 = &v)
		{
			Core.Color3usv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color3(ushort* v)
	{
		Core.Color3usv(v);
	}

	[CLSCompliant(false)]
	public static void Color4(sbyte red, sbyte green, sbyte blue, sbyte alpha)
	{
		Core.Color4b(red, green, blue, alpha);
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(sbyte[] v)
	{
		fixed (sbyte* v2 = v)
		{
			Core.Color4bv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(ref sbyte v)
	{
		fixed (sbyte* v2 = &v)
		{
			Core.Color4bv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(sbyte* v)
	{
		Core.Color4bv(v);
	}

	public static void Color4(double red, double green, double blue, double alpha)
	{
		Core.Color4d(red, green, blue, alpha);
	}

	public unsafe static void Color4(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.Color4dv(v2);
		}
	}

	public unsafe static void Color4(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.Color4dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(double* v)
	{
		Core.Color4dv(v);
	}

	public static void Color4(float red, float green, float blue, float alpha)
	{
		Core.Color4f(red, green, blue, alpha);
	}

	public unsafe static void Color4(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.Color4fv(v2);
		}
	}

	public unsafe static void Color4(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.Color4fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(float* v)
	{
		Core.Color4fv(v);
	}

	public static void Color4(int red, int green, int blue, int alpha)
	{
		Core.Color4i(red, green, blue, alpha);
	}

	public unsafe static void Color4(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.Color4iv(v2);
		}
	}

	public unsafe static void Color4(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.Color4iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(int* v)
	{
		Core.Color4iv(v);
	}

	public static void Color4(short red, short green, short blue, short alpha)
	{
		Core.Color4s(red, green, blue, alpha);
	}

	public unsafe static void Color4(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.Color4sv(v2);
		}
	}

	public unsafe static void Color4(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.Color4sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(short* v)
	{
		Core.Color4sv(v);
	}

	public static void Color4(byte red, byte green, byte blue, byte alpha)
	{
		Core.Color4ub(red, green, blue, alpha);
	}

	public unsafe static void Color4(byte[] v)
	{
		fixed (byte* v2 = v)
		{
			Core.Color4ubv(v2);
		}
	}

	public unsafe static void Color4(ref byte v)
	{
		fixed (byte* v2 = &v)
		{
			Core.Color4ubv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(byte* v)
	{
		Core.Color4ubv(v);
	}

	[CLSCompliant(false)]
	public static void Color4(uint red, uint green, uint blue, uint alpha)
	{
		Core.Color4ui(red, green, blue, alpha);
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(uint[] v)
	{
		fixed (uint* v2 = v)
		{
			Core.Color4uiv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(ref uint v)
	{
		fixed (uint* v2 = &v)
		{
			Core.Color4uiv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(uint* v)
	{
		Core.Color4uiv(v);
	}

	[CLSCompliant(false)]
	public static void Color4(ushort red, ushort green, ushort blue, ushort alpha)
	{
		Core.Color4us(red, green, blue, alpha);
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(ushort[] v)
	{
		fixed (ushort* v2 = v)
		{
			Core.Color4usv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(ref ushort v)
	{
		fixed (ushort* v2 = &v)
		{
			Core.Color4usv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Color4(ushort* v)
	{
		Core.Color4usv(v);
	}

	public static void ColorMask(bool red, bool green, bool blue, bool alpha)
	{
		Core.ColorMask(red, green, blue, alpha);
	}

	public static void ColorMaterial(MaterialFace face, ColorMaterialParameter mode)
	{
		Core.ColorMaterial(face, mode);
	}

	public static void ColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer)
	{
		Core.ColorPointer(size, type, stride, pointer);
	}

	public static void ColorPointer<T3>(int size, ColorPointerType type, int stride, [In][Out] T3[] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.ColorPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ColorPointer<T3>(int size, ColorPointerType type, int stride, [In][Out] T3[,] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.ColorPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ColorPointer<T3>(int size, ColorPointerType type, int stride, [In][Out] T3[,,] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.ColorPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ColorPointer<T3>(int size, ColorPointerType type, int stride, [In][Out] ref T3 pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.ColorPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
			pointer = (T3)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ColorSubTable(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, IntPtr data)
	{
		Core.ColorSubTable(target, start, count, format, type, data);
	}

	public static void ColorSubTable<T5>(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, [In][Out] T5[] data) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.ColorSubTable(target, start, count, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ColorSubTable<T5>(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, [In][Out] T5[,] data) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.ColorSubTable(target, start, count, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ColorSubTable<T5>(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, [In][Out] T5[,,] data) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.ColorSubTable(target, start, count, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ColorSubTable<T5>(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, [In][Out] ref T5 data) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.ColorSubTable(target, start, count, format, type, gCHandle.AddrOfPinnedObject());
			data = (T5)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ColorTable(ColorTableTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, IntPtr table)
	{
		Core.ColorTable(target, internalformat, width, format, type, table);
	}

	public static void ColorTable<T5>(ColorTableTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, [In][Out] T5[] table) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(table, GCHandleType.Pinned);
		try
		{
			Core.ColorTable(target, internalformat, width, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ColorTable<T5>(ColorTableTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, [In][Out] T5[,] table) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(table, GCHandleType.Pinned);
		try
		{
			Core.ColorTable(target, internalformat, width, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ColorTable<T5>(ColorTableTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, [In][Out] T5[,,] table) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(table, GCHandleType.Pinned);
		try
		{
			Core.ColorTable(target, internalformat, width, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ColorTable<T5>(ColorTableTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, [In][Out] ref T5 table) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(table, GCHandleType.Pinned);
		try
		{
			Core.ColorTable(target, internalformat, width, format, type, gCHandle.AddrOfPinnedObject());
			table = (T5)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public unsafe static void ColorTableParameter(ColorTableTarget target, ColorTableParameterPName pname, float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.ColorTableParameterfv(target, pname, params2);
		}
	}

	public unsafe static void ColorTableParameter(ColorTableTarget target, ColorTableParameterPName pname, ref float @params)
	{
		fixed (float* params2 = &@params)
		{
			Core.ColorTableParameterfv(target, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void ColorTableParameter(ColorTableTarget target, ColorTableParameterPName pname, float* @params)
	{
		Core.ColorTableParameterfv(target, pname, @params);
	}

	public unsafe static void ColorTableParameter(ColorTableTarget target, ColorTableParameterPName pname, int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.ColorTableParameteriv(target, pname, params2);
		}
	}

	public unsafe static void ColorTableParameter(ColorTableTarget target, ColorTableParameterPName pname, ref int @params)
	{
		fixed (int* params2 = &@params)
		{
			Core.ColorTableParameteriv(target, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void ColorTableParameter(ColorTableTarget target, ColorTableParameterPName pname, int* @params)
	{
		Core.ColorTableParameteriv(target, pname, @params);
	}

	public static void CompileShader(int shader)
	{
		Core.CompileShader((uint)shader);
	}

	[CLSCompliant(false)]
	public static void CompileShader(uint shader)
	{
		Core.CompileShader(shader);
	}

	public static void CompressedTexImage1D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, IntPtr data)
	{
		Core.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
	}

	public static void CompressedTexImage1D<T6>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, [In][Out] T6[] data) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexImage1D<T6>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, [In][Out] T6[,] data) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexImage1D<T6>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, [In][Out] T6[,,] data) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexImage1D<T6>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, int imageSize, [In][Out] ref T6 data) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, gCHandle.AddrOfPinnedObject());
			data = (T6)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data)
	{
		Core.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
	}

	public static void CompressedTexImage2D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, [In][Out] T7[] data) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexImage2D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, [In][Out] T7[,] data) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexImage2D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, [In][Out] T7[,,] data) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexImage2D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, int imageSize, [In][Out] ref T7 data) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, gCHandle.AddrOfPinnedObject());
			data = (T7)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexImage3D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
	{
		Core.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
	}

	public static void CompressedTexImage3D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, [In][Out] T8[] data) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexImage3D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, [In][Out] T8[,] data) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexImage3D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, [In][Out] T8[,,] data) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexImage3D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, [In][Out] ref T8 data) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, gCHandle.AddrOfPinnedObject());
			data = (T8)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data)
	{
		Core.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
	}

	public static void CompressedTexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, [In][Out] T6[] data) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, [In][Out] T6[,] data) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, [In][Out] T6[,,] data) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, [In][Out] ref T6 data) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, gCHandle.AddrOfPinnedObject());
			data = (T6)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
	{
		Core.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
	}

	public static void CompressedTexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, [In][Out] T8[] data) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, [In][Out] T8[,] data) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, [In][Out] T8[,,] data) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, [In][Out] ref T8 data) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, gCHandle.AddrOfPinnedObject());
			data = (T8)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data)
	{
		Core.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}

	public static void CompressedTexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, [In][Out] T10[] data) where T10 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, [In][Out] T10[,] data) where T10 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, [In][Out] T10[,,] data) where T10 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CompressedTexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, [In][Out] ref T10 data) where T10 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, gCHandle.AddrOfPinnedObject());
			data = (T10)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ConvolutionFilter1D(ConvolutionTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, IntPtr image)
	{
		Core.ConvolutionFilter1D(target, internalformat, width, format, type, image);
	}

	public static void ConvolutionFilter1D<T5>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, [In][Out] T5[] image) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.ConvolutionFilter1D(target, internalformat, width, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ConvolutionFilter1D<T5>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, [In][Out] T5[,] image) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.ConvolutionFilter1D(target, internalformat, width, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ConvolutionFilter1D<T5>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, [In][Out] T5[,,] image) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.ConvolutionFilter1D(target, internalformat, width, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ConvolutionFilter1D<T5>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, PixelFormat format, PixelType type, [In][Out] ref T5 image) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.ConvolutionFilter1D(target, internalformat, width, format, type, gCHandle.AddrOfPinnedObject());
			image = (T5)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ConvolutionFilter2D(ConvolutionTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr image)
	{
		Core.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
	}

	public static void ConvolutionFilter2D<T6>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, [In][Out] T6[] image) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.ConvolutionFilter2D(target, internalformat, width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ConvolutionFilter2D<T6>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, [In][Out] T6[,] image) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.ConvolutionFilter2D(target, internalformat, width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ConvolutionFilter2D<T6>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, [In][Out] T6[,,] image) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.ConvolutionFilter2D(target, internalformat, width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ConvolutionFilter2D<T6>(ConvolutionTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, [In][Out] ref T6 image) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.ConvolutionFilter2D(target, internalformat, width, height, format, type, gCHandle.AddrOfPinnedObject());
			image = (T6)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ConvolutionParameter(ConvolutionTarget target, ConvolutionParameter pname, float @params)
	{
		Core.ConvolutionParameterf(target, pname, @params);
	}

	public unsafe static void ConvolutionParameter(ConvolutionTarget target, ConvolutionParameter pname, float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.ConvolutionParameterfv(target, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void ConvolutionParameter(ConvolutionTarget target, ConvolutionParameter pname, float* @params)
	{
		Core.ConvolutionParameterfv(target, pname, @params);
	}

	public static void ConvolutionParameter(ConvolutionTarget target, ConvolutionParameter pname, int @params)
	{
		Core.ConvolutionParameteri(target, pname, @params);
	}

	public unsafe static void ConvolutionParameter(ConvolutionTarget target, ConvolutionParameter pname, int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.ConvolutionParameteriv(target, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void ConvolutionParameter(ConvolutionTarget target, ConvolutionParameter pname, int* @params)
	{
		Core.ConvolutionParameteriv(target, pname, @params);
	}

	public static void CopyBufferSubData(BufferTarget readTarget, BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
	{
		Core.CopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
	}

	public static void CopyColorSubTable(ColorTableTarget target, int start, int x, int y, int width)
	{
		Core.CopyColorSubTable(target, start, x, y, width);
	}

	public static void CopyColorTable(ColorTableTarget target, PixelInternalFormat internalformat, int x, int y, int width)
	{
		Core.CopyColorTable(target, internalformat, x, y, width);
	}

	public static void CopyConvolutionFilter1D(ConvolutionTarget target, PixelInternalFormat internalformat, int x, int y, int width)
	{
		Core.CopyConvolutionFilter1D(target, internalformat, x, y, width);
	}

	public static void CopyConvolutionFilter2D(ConvolutionTarget target, PixelInternalFormat internalformat, int x, int y, int width, int height)
	{
		Core.CopyConvolutionFilter2D(target, internalformat, x, y, width, height);
	}

	public static void CopyPixels(int x, int y, int width, int height, PixelCopyType type)
	{
		Core.CopyPixels(x, y, width, height, type);
	}

	public static void CopyTexImage1D(TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int border)
	{
		Core.CopyTexImage1D(target, level, internalformat, x, y, width, border);
	}

	public static void CopyTexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border)
	{
		Core.CopyTexImage2D(target, level, internalformat, x, y, width, height, border);
	}

	public static void CopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, int width)
	{
		Core.CopyTexSubImage1D(target, level, xoffset, x, y, width);
	}

	public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
	{
		Core.CopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
	}

	public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
	{
		Core.CopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
	}

	public static int CreateProgram()
	{
		return Core.CreateProgram();
	}

	public static int CreateShader(ShaderType type)
	{
		return Core.CreateShader(type);
	}

	public static void CullFace(CullFaceMode mode)
	{
		Core.CullFace(mode);
	}

	public unsafe static void DeleteBuffers(int n, int[] buffers)
	{
		fixed (int* buffers2 = buffers)
		{
			Core.DeleteBuffers(n, (uint*)buffers2);
		}
	}

	public unsafe static void DeleteBuffers(int n, ref int buffers)
	{
		fixed (int* buffers2 = &buffers)
		{
			Core.DeleteBuffers(n, (uint*)buffers2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteBuffers(int n, int* buffers)
	{
		Core.DeleteBuffers(n, (uint*)buffers);
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteBuffers(int n, uint[] buffers)
	{
		fixed (uint* buffers2 = buffers)
		{
			Core.DeleteBuffers(n, buffers2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteBuffers(int n, ref uint buffers)
	{
		fixed (uint* buffers2 = &buffers)
		{
			Core.DeleteBuffers(n, buffers2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteBuffers(int n, uint* buffers)
	{
		Core.DeleteBuffers(n, buffers);
	}

	public static void DeleteLists(int list, int range)
	{
		Core.DeleteLists((uint)list, range);
	}

	[CLSCompliant(false)]
	public static void DeleteLists(uint list, int range)
	{
		Core.DeleteLists(list, range);
	}

	public unsafe static void DeleteQueries(int n, int[] ids)
	{
		fixed (int* ids2 = ids)
		{
			Core.DeleteQueries(n, (uint*)ids2);
		}
	}

	public unsafe static void DeleteQueries(int n, ref int ids)
	{
		fixed (int* ids2 = &ids)
		{
			Core.DeleteQueries(n, (uint*)ids2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteQueries(int n, int* ids)
	{
		Core.DeleteQueries(n, (uint*)ids);
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteQueries(int n, uint[] ids)
	{
		fixed (uint* ids2 = ids)
		{
			Core.DeleteQueries(n, ids2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteQueries(int n, ref uint ids)
	{
		fixed (uint* ids2 = &ids)
		{
			Core.DeleteQueries(n, ids2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteQueries(int n, uint* ids)
	{
		Core.DeleteQueries(n, ids);
	}

	public static void DeleteShader(int shader)
	{
		Core.DeleteShader((uint)shader);
	}

	[CLSCompliant(false)]
	public static void DeleteShader(uint shader)
	{
		Core.DeleteShader(shader);
	}

	public unsafe static void DeleteTextures(int n, int[] textures)
	{
		fixed (int* textures2 = textures)
		{
			Core.DeleteTextures(n, (uint*)textures2);
		}
	}

	public unsafe static void DeleteTextures(int n, ref int textures)
	{
		fixed (int* textures2 = &textures)
		{
			Core.DeleteTextures(n, (uint*)textures2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteTextures(int n, int* textures)
	{
		Core.DeleteTextures(n, (uint*)textures);
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteTextures(int n, uint[] textures)
	{
		fixed (uint* textures2 = textures)
		{
			Core.DeleteTextures(n, textures2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteTextures(int n, ref uint textures)
	{
		fixed (uint* textures2 = &textures)
		{
			Core.DeleteTextures(n, textures2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteTextures(int n, uint* textures)
	{
		Core.DeleteTextures(n, textures);
	}

	public static void DepthFunc(DepthFunction func)
	{
		Core.DepthFunc(func);
	}

	public static void DepthMask(bool flag)
	{
		Core.DepthMask(flag);
	}

	public static void DepthRange(double near, double far)
	{
		Core.DepthRange(near, far);
	}

	public static void DetachShader(int program, int shader)
	{
		Core.DetachShader((uint)program, (uint)shader);
	}

	[CLSCompliant(false)]
	public static void DetachShader(uint program, uint shader)
	{
		Core.DetachShader(program, shader);
	}

	public static void Disable(EnableCap cap)
	{
		Core.Disable(cap);
	}

	public static void DisableClientState(ArrayCap array)
	{
		Core.DisableClientState(array);
	}

	public static void Disable(IndexedEnableCap target, int index)
	{
		Core.Disablei(target, (uint)index);
	}

	[CLSCompliant(false)]
	public static void Disable(IndexedEnableCap target, uint index)
	{
		Core.Disablei(target, index);
	}

	public static void DisableVertexAttribArray(int index)
	{
		Core.DisableVertexAttribArray((uint)index);
	}

	[CLSCompliant(false)]
	public static void DisableVertexAttribArray(uint index)
	{
		Core.DisableVertexAttribArray(index);
	}

	public static void DrawArrays(BeginMode mode, int first, int count)
	{
		Core.DrawArrays(mode, first, count);
	}

	public static void DrawBuffer(DrawBufferMode mode)
	{
		Core.DrawBuffer(mode);
	}

	public unsafe static void DrawBuffers(int n, DrawBuffersEnum[] bufs)
	{
		fixed (DrawBuffersEnum* bufs2 = bufs)
		{
			Core.DrawBuffers(n, bufs2);
		}
	}

	public unsafe static void DrawBuffers(int n, ref DrawBuffersEnum bufs)
	{
		fixed (DrawBuffersEnum* bufs2 = &bufs)
		{
			Core.DrawBuffers(n, bufs2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DrawBuffers(int n, DrawBuffersEnum* bufs)
	{
		Core.DrawBuffers(n, bufs);
	}

	public static void DrawElements(BeginMode mode, int count, DrawElementsType type, IntPtr indices)
	{
		Core.DrawElements(mode, count, type, indices);
	}

	public static void DrawElements<T3>(BeginMode mode, int count, DrawElementsType type, [In][Out] T3[] indices) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawElements(mode, count, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void DrawElements<T3>(BeginMode mode, int count, DrawElementsType type, [In][Out] T3[,] indices) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawElements(mode, count, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void DrawElements<T3>(BeginMode mode, int count, DrawElementsType type, [In][Out] T3[,,] indices) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawElements(mode, count, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void DrawElements<T3>(BeginMode mode, int count, DrawElementsType type, [In][Out] ref T3 indices) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawElements(mode, count, type, gCHandle.AddrOfPinnedObject());
			indices = (T3)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void DrawPixels(int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
	{
		Core.DrawPixels(width, height, format, type, pixels);
	}

	public static void DrawPixels<T4>(int width, int height, PixelFormat format, PixelType type, [In][Out] T4[] pixels) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.DrawPixels(width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void DrawPixels<T4>(int width, int height, PixelFormat format, PixelType type, [In][Out] T4[,] pixels) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.DrawPixels(width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void DrawPixels<T4>(int width, int height, PixelFormat format, PixelType type, [In][Out] T4[,,] pixels) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.DrawPixels(width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void DrawPixels<T4>(int width, int height, PixelFormat format, PixelType type, [In][Out] ref T4 pixels) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.DrawPixels(width, height, format, type, gCHandle.AddrOfPinnedObject());
			pixels = (T4)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void DrawRangeElements(BeginMode mode, int start, int end, int count, DrawElementsType type, IntPtr indices)
	{
		Core.DrawRangeElements(mode, (uint)start, (uint)end, count, type, indices);
	}

	public static void DrawRangeElements<T5>(BeginMode mode, int start, int end, int count, DrawElementsType type, [In][Out] T5[] indices) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawRangeElements(mode, (uint)start, (uint)end, count, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void DrawRangeElements<T5>(BeginMode mode, int start, int end, int count, DrawElementsType type, [In][Out] T5[,] indices) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawRangeElements(mode, (uint)start, (uint)end, count, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void DrawRangeElements<T5>(BeginMode mode, int start, int end, int count, DrawElementsType type, [In][Out] T5[,,] indices) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawRangeElements(mode, (uint)start, (uint)end, count, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void DrawRangeElements<T5>(BeginMode mode, int start, int end, int count, DrawElementsType type, [In][Out] ref T5 indices) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawRangeElements(mode, (uint)start, (uint)end, count, type, gCHandle.AddrOfPinnedObject());
			indices = (T5)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void DrawRangeElements(BeginMode mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices)
	{
		Core.DrawRangeElements(mode, start, end, count, type, indices);
	}

	[CLSCompliant(false)]
	public static void DrawRangeElements<T5>(BeginMode mode, uint start, uint end, int count, DrawElementsType type, [In][Out] T5[] indices) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawRangeElements(mode, start, end, count, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void DrawRangeElements<T5>(BeginMode mode, uint start, uint end, int count, DrawElementsType type, [In][Out] T5[,] indices) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawRangeElements(mode, start, end, count, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void DrawRangeElements<T5>(BeginMode mode, uint start, uint end, int count, DrawElementsType type, [In][Out] T5[,,] indices) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawRangeElements(mode, start, end, count, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void DrawRangeElements<T5>(BeginMode mode, uint start, uint end, int count, DrawElementsType type, [In][Out] ref T5 indices) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.DrawRangeElements(mode, start, end, count, type, gCHandle.AddrOfPinnedObject());
			indices = (T5)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void EdgeFlag(bool flag)
	{
		Core.EdgeFlag(flag);
	}

	public static void EdgeFlagPointer(int stride, IntPtr pointer)
	{
		Core.EdgeFlagPointer(stride, pointer);
	}

	public static void EdgeFlagPointer<T1>(int stride, [In][Out] T1[] pointer) where T1 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.EdgeFlagPointer(stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void EdgeFlagPointer<T1>(int stride, [In][Out] T1[,] pointer) where T1 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.EdgeFlagPointer(stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void EdgeFlagPointer<T1>(int stride, [In][Out] T1[,,] pointer) where T1 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.EdgeFlagPointer(stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void EdgeFlagPointer<T1>(int stride, [In][Out] ref T1 pointer) where T1 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.EdgeFlagPointer(stride, gCHandle.AddrOfPinnedObject());
			pointer = (T1)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public unsafe static void EdgeFlag(bool* flag)
	{
		Core.EdgeFlagv(flag);
	}

	public static void Enable(EnableCap cap)
	{
		Core.Enable(cap);
	}

	public static void EnableClientState(ArrayCap array)
	{
		Core.EnableClientState(array);
	}

	public static void Enable(IndexedEnableCap target, int index)
	{
		Core.Enablei(target, (uint)index);
	}

	[CLSCompliant(false)]
	public static void Enable(IndexedEnableCap target, uint index)
	{
		Core.Enablei(target, index);
	}

	public static void EnableVertexAttribArray(int index)
	{
		Core.EnableVertexAttribArray((uint)index);
	}

	[CLSCompliant(false)]
	public static void EnableVertexAttribArray(uint index)
	{
		Core.EnableVertexAttribArray(index);
	}

	public static void End()
	{
		Core.End();
	}

	public static void EndList()
	{
		Core.EndList();
	}

	public static void EndQuery(QueryTarget target)
	{
		Core.EndQuery(target);
	}

	public static void EvalCoord1(double u)
	{
		Core.EvalCoord1d(u);
	}

	[CLSCompliant(false)]
	public unsafe static void EvalCoord1(double* u)
	{
		Core.EvalCoord1dv(u);
	}

	public static void EvalCoord1(float u)
	{
		Core.EvalCoord1f(u);
	}

	[CLSCompliant(false)]
	public unsafe static void EvalCoord1(float* u)
	{
		Core.EvalCoord1fv(u);
	}

	public static void EvalCoord2(double u, double v)
	{
		Core.EvalCoord2d(u, v);
	}

	public unsafe static void EvalCoord2(double[] u)
	{
		fixed (double* u2 = u)
		{
			Core.EvalCoord2dv(u2);
		}
	}

	public unsafe static void EvalCoord2(ref double u)
	{
		fixed (double* u2 = &u)
		{
			Core.EvalCoord2dv(u2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void EvalCoord2(double* u)
	{
		Core.EvalCoord2dv(u);
	}

	public static void EvalCoord2(float u, float v)
	{
		Core.EvalCoord2f(u, v);
	}

	public unsafe static void EvalCoord2(float[] u)
	{
		fixed (float* u2 = u)
		{
			Core.EvalCoord2fv(u2);
		}
	}

	public unsafe static void EvalCoord2(ref float u)
	{
		fixed (float* u2 = &u)
		{
			Core.EvalCoord2fv(u2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void EvalCoord2(float* u)
	{
		Core.EvalCoord2fv(u);
	}

	public static void EvalMesh1(MeshMode1 mode, int i1, int i2)
	{
		Core.EvalMesh1(mode, i1, i2);
	}

	public static void EvalMesh2(MeshMode2 mode, int i1, int i2, int j1, int j2)
	{
		Core.EvalMesh2(mode, i1, i2, j1, j2);
	}

	public static void EvalPoint1(int i)
	{
		Core.EvalPoint1(i);
	}

	public static void EvalPoint2(int i, int j)
	{
		Core.EvalPoint2(i, j);
	}

	public unsafe static void FeedbackBuffer(int size, FeedbackType type, [Out] float[] buffer)
	{
		fixed (float* buffer2 = buffer)
		{
			Core.FeedbackBuffer(size, type, buffer2);
		}
	}

	public unsafe static void FeedbackBuffer(int size, FeedbackType type, out float buffer)
	{
		fixed (float* ptr = &buffer)
		{
			Core.FeedbackBuffer(size, type, ptr);
			buffer = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void FeedbackBuffer(int size, FeedbackType type, [Out] float* buffer)
	{
		Core.FeedbackBuffer(size, type, buffer);
	}

	public static void Finish()
	{
		Core.Finish();
	}

	public static void Flush()
	{
		Core.Flush();
	}

	public static void FogCoord(double coord)
	{
		Core.FogCoordd(coord);
	}

	[CLSCompliant(false)]
	public unsafe static void FogCoord(double* coord)
	{
		Core.FogCoorddv(coord);
	}

	public static void FogCoord(float coord)
	{
		Core.FogCoordf(coord);
	}

	[CLSCompliant(false)]
	public unsafe static void FogCoord(float* coord)
	{
		Core.FogCoordfv(coord);
	}

	public static void FogCoordPointer(FogPointerType type, int stride, IntPtr pointer)
	{
		Core.FogCoordPointer(type, stride, pointer);
	}

	public static void FogCoordPointer<T2>(FogPointerType type, int stride, [In][Out] T2[] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.FogCoordPointer(type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void FogCoordPointer<T2>(FogPointerType type, int stride, [In][Out] T2[,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.FogCoordPointer(type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void FogCoordPointer<T2>(FogPointerType type, int stride, [In][Out] T2[,,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.FogCoordPointer(type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void FogCoordPointer<T2>(FogPointerType type, int stride, [In][Out] ref T2 pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.FogCoordPointer(type, stride, gCHandle.AddrOfPinnedObject());
			pointer = (T2)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void Fog(FogParameter pname, float param)
	{
		Core.Fogf(pname, param);
	}

	public unsafe static void Fog(FogParameter pname, float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.Fogfv(pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Fog(FogParameter pname, float* @params)
	{
		Core.Fogfv(pname, @params);
	}

	public static void Fog(FogParameter pname, int param)
	{
		Core.Fogi(pname, param);
	}

	public unsafe static void Fog(FogParameter pname, int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.Fogiv(pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Fog(FogParameter pname, int* @params)
	{
		Core.Fogiv(pname, @params);
	}

	public static void FrontFace(FrontFaceDirection mode)
	{
		Core.FrontFace(mode);
	}

	public static void Frustum(double left, double right, double bottom, double top, double zNear, double zFar)
	{
		Core.Frustum(left, right, bottom, top, zNear, zFar);
	}

	public unsafe static void GenBuffers(int n, [Out] int[] buffers)
	{
		fixed (int* buffers2 = buffers)
		{
			Core.GenBuffers(n, (uint*)buffers2);
		}
	}

	public unsafe static void GenBuffers(int n, out int buffers)
	{
		fixed (int* ptr = &buffers)
		{
			Core.GenBuffers(n, (uint*)ptr);
			buffers = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GenBuffers(int n, [Out] int* buffers)
	{
		Core.GenBuffers(n, (uint*)buffers);
	}

	[CLSCompliant(false)]
	public unsafe static void GenBuffers(int n, [Out] uint[] buffers)
	{
		fixed (uint* buffers2 = buffers)
		{
			Core.GenBuffers(n, buffers2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GenBuffers(int n, out uint buffers)
	{
		fixed (uint* ptr = &buffers)
		{
			Core.GenBuffers(n, ptr);
			buffers = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GenBuffers(int n, [Out] uint* buffers)
	{
		Core.GenBuffers(n, buffers);
	}

	public static int GenLists(int range)
	{
		return Core.GenLists(range);
	}

	public unsafe static void GenQueries(int n, [Out] int[] ids)
	{
		fixed (int* ids2 = ids)
		{
			Core.GenQueries(n, (uint*)ids2);
		}
	}

	public unsafe static void GenQueries(int n, out int ids)
	{
		fixed (int* ptr = &ids)
		{
			Core.GenQueries(n, (uint*)ptr);
			ids = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GenQueries(int n, [Out] int* ids)
	{
		Core.GenQueries(n, (uint*)ids);
	}

	[CLSCompliant(false)]
	public unsafe static void GenQueries(int n, [Out] uint[] ids)
	{
		fixed (uint* ids2 = ids)
		{
			Core.GenQueries(n, ids2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GenQueries(int n, out uint ids)
	{
		fixed (uint* ptr = &ids)
		{
			Core.GenQueries(n, ptr);
			ids = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GenQueries(int n, [Out] uint* ids)
	{
		Core.GenQueries(n, ids);
	}

	public unsafe static void GenTextures(int n, [Out] int[] textures)
	{
		fixed (int* textures2 = textures)
		{
			Core.GenTextures(n, (uint*)textures2);
		}
	}

	public unsafe static void GenTextures(int n, out int textures)
	{
		fixed (int* ptr = &textures)
		{
			Core.GenTextures(n, (uint*)ptr);
			textures = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GenTextures(int n, [Out] int* textures)
	{
		Core.GenTextures(n, (uint*)textures);
	}

	[CLSCompliant(false)]
	public unsafe static void GenTextures(int n, [Out] uint[] textures)
	{
		fixed (uint* textures2 = textures)
		{
			Core.GenTextures(n, textures2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GenTextures(int n, out uint textures)
	{
		fixed (uint* ptr = &textures)
		{
			Core.GenTextures(n, ptr);
			textures = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GenTextures(int n, [Out] uint* textures)
	{
		Core.GenTextures(n, textures);
	}

	public unsafe static void GetActiveAttrib(int program, int index, int bufSize, out int length, out int size, out ActiveAttribType type, [Out] StringBuilder name)
	{
		fixed (int* ptr = &length)
		{
			fixed (int* ptr2 = &size)
			{
				fixed (ActiveAttribType* ptr3 = &type)
				{
					Core.GetActiveAttrib((uint)program, (uint)index, bufSize, ptr, ptr2, ptr3, name);
					length = *ptr;
					size = *ptr2;
					type = *ptr3;
				}
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetActiveAttrib(int program, int index, int bufSize, [Out] int* length, [Out] int* size, [Out] ActiveAttribType* type, [Out] StringBuilder name)
	{
		Core.GetActiveAttrib((uint)program, (uint)index, bufSize, length, size, type, name);
	}

	[CLSCompliant(false)]
	public unsafe static void GetActiveAttrib(uint program, uint index, int bufSize, out int length, out int size, out ActiveAttribType type, [Out] StringBuilder name)
	{
		fixed (int* ptr = &length)
		{
			fixed (int* ptr2 = &size)
			{
				fixed (ActiveAttribType* ptr3 = &type)
				{
					Core.GetActiveAttrib(program, index, bufSize, ptr, ptr2, ptr3, name);
					length = *ptr;
					size = *ptr2;
					type = *ptr3;
				}
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetActiveAttrib(uint program, uint index, int bufSize, [Out] int* length, [Out] int* size, [Out] ActiveAttribType* type, [Out] StringBuilder name)
	{
		Core.GetActiveAttrib(program, index, bufSize, length, size, type, name);
	}

	public unsafe static void GetActiveUniform(int program, int index, int bufSize, out int length, out int size, out ActiveUniformType type, [Out] StringBuilder name)
	{
		fixed (int* ptr = &length)
		{
			fixed (int* ptr2 = &size)
			{
				fixed (ActiveUniformType* ptr3 = &type)
				{
					Core.GetActiveUniform((uint)program, (uint)index, bufSize, ptr, ptr2, ptr3, name);
					length = *ptr;
					size = *ptr2;
					type = *ptr3;
				}
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetActiveUniform(int program, int index, int bufSize, [Out] int* length, [Out] int* size, [Out] ActiveUniformType* type, [Out] StringBuilder name)
	{
		Core.GetActiveUniform((uint)program, (uint)index, bufSize, length, size, type, name);
	}

	[CLSCompliant(false)]
	public unsafe static void GetActiveUniform(uint program, uint index, int bufSize, out int length, out int size, out ActiveUniformType type, [Out] StringBuilder name)
	{
		fixed (int* ptr = &length)
		{
			fixed (int* ptr2 = &size)
			{
				fixed (ActiveUniformType* ptr3 = &type)
				{
					Core.GetActiveUniform(program, index, bufSize, ptr, ptr2, ptr3, name);
					length = *ptr;
					size = *ptr2;
					type = *ptr3;
				}
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetActiveUniform(uint program, uint index, int bufSize, [Out] int* length, [Out] int* size, [Out] ActiveUniformType* type, [Out] StringBuilder name)
	{
		Core.GetActiveUniform(program, index, bufSize, length, size, type, name);
	}

	public unsafe static void GetAttachedShaders(int program, int maxCount, out int count, out int obj)
	{
		fixed (int* ptr = &count)
		{
			fixed (int* ptr2 = &obj)
			{
				Core.GetAttachedShaders((uint)program, maxCount, ptr, (uint*)ptr2);
				count = *ptr;
				obj = *ptr2;
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetAttachedShaders(int program, int maxCount, [Out] int* count, [Out] int[] obj)
	{
		fixed (int* obj2 = obj)
		{
			Core.GetAttachedShaders((uint)program, maxCount, count, (uint*)obj2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetAttachedShaders(int program, int maxCount, [Out] int* count, [Out] int* obj)
	{
		Core.GetAttachedShaders((uint)program, maxCount, count, (uint*)obj);
	}

	[CLSCompliant(false)]
	public unsafe static void GetAttachedShaders(uint program, int maxCount, out int count, out uint obj)
	{
		fixed (int* ptr = &count)
		{
			fixed (uint* ptr2 = &obj)
			{
				Core.GetAttachedShaders(program, maxCount, ptr, ptr2);
				count = *ptr;
				obj = *ptr2;
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetAttachedShaders(uint program, int maxCount, [Out] int* count, [Out] uint[] obj)
	{
		fixed (uint* obj2 = obj)
		{
			Core.GetAttachedShaders(program, maxCount, count, obj2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetAttachedShaders(uint program, int maxCount, [Out] int* count, [Out] uint* obj)
	{
		Core.GetAttachedShaders(program, maxCount, count, obj);
	}

	public static int GetAttribLocation(int program, string name)
	{
		return Core.GetAttribLocation((uint)program, name);
	}

	[CLSCompliant(false)]
	public static int GetAttribLocation(uint program, string name)
	{
		return Core.GetAttribLocation(program, name);
	}

	public unsafe static void GetBoolean(GetIndexedPName target, int index, [Out] bool[] data)
	{
		fixed (bool* data2 = data)
		{
			Core.GetBooleani_v(target, (uint)index, data2);
		}
	}

	public unsafe static void GetBoolean(GetIndexedPName target, int index, out bool data)
	{
		fixed (bool* ptr = &data)
		{
			Core.GetBooleani_v(target, (uint)index, ptr);
			data = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetBoolean(GetIndexedPName target, int index, [Out] bool* data)
	{
		Core.GetBooleani_v(target, (uint)index, data);
	}

	[CLSCompliant(false)]
	public unsafe static void GetBoolean(GetIndexedPName target, uint index, [Out] bool[] data)
	{
		fixed (bool* data2 = data)
		{
			Core.GetBooleani_v(target, index, data2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetBoolean(GetIndexedPName target, uint index, out bool data)
	{
		fixed (bool* ptr = &data)
		{
			Core.GetBooleani_v(target, index, ptr);
			data = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetBoolean(GetIndexedPName target, uint index, [Out] bool* data)
	{
		Core.GetBooleani_v(target, index, data);
	}

	public unsafe static void GetBoolean(GetPName pname, [Out] bool[] @params)
	{
		fixed (bool* params2 = @params)
		{
			Core.GetBooleanv(pname, params2);
		}
	}

	public unsafe static void GetBoolean(GetPName pname, out bool @params)
	{
		fixed (bool* ptr = &@params)
		{
			Core.GetBooleanv(pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetBoolean(GetPName pname, [Out] bool* @params)
	{
		Core.GetBooleanv(pname, @params);
	}

	public unsafe static void GetBufferParameter(BufferTarget target, BufferParameterName pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetBufferParameteriv(target, pname, params2);
		}
	}

	public unsafe static void GetBufferParameter(BufferTarget target, BufferParameterName pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetBufferParameteriv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetBufferParameter(BufferTarget target, BufferParameterName pname, [Out] int* @params)
	{
		Core.GetBufferParameteriv(target, pname, @params);
	}

	public static void GetBufferPointer(BufferTarget target, BufferPointer pname, [Out] IntPtr @params)
	{
		Core.GetBufferPointerv(target, pname, @params);
	}

	public static void GetBufferPointer<T2>(BufferTarget target, BufferPointer pname, [In][Out] T2[] @params) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(@params, GCHandleType.Pinned);
		try
		{
			Core.GetBufferPointerv(target, pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetBufferPointer<T2>(BufferTarget target, BufferPointer pname, [In][Out] T2[,] @params) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(@params, GCHandleType.Pinned);
		try
		{
			Core.GetBufferPointerv(target, pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetBufferPointer<T2>(BufferTarget target, BufferPointer pname, [In][Out] T2[,,] @params) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(@params, GCHandleType.Pinned);
		try
		{
			Core.GetBufferPointerv(target, pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetBufferPointer<T2>(BufferTarget target, BufferPointer pname, [In][Out] ref T2 @params) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(@params, GCHandleType.Pinned);
		try
		{
			Core.GetBufferPointerv(target, pname, gCHandle.AddrOfPinnedObject());
			@params = (T2)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetBufferSubData(BufferTarget target, IntPtr offset, IntPtr size, [Out] IntPtr data)
	{
		Core.GetBufferSubData(target, offset, size, data);
	}

	public static void GetBufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, [In][Out] T3[] data) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.GetBufferSubData(target, offset, size, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetBufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, [In][Out] T3[,] data) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.GetBufferSubData(target, offset, size, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetBufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, [In][Out] T3[,,] data) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.GetBufferSubData(target, offset, size, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetBufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, [In][Out] ref T3 data) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			Core.GetBufferSubData(target, offset, size, gCHandle.AddrOfPinnedObject());
			data = (T3)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public unsafe static void GetClipPlane(ClipPlaneName plane, [Out] double[] equation)
	{
		fixed (double* equation2 = equation)
		{
			Core.GetClipPlane(plane, equation2);
		}
	}

	public unsafe static void GetClipPlane(ClipPlaneName plane, out double equation)
	{
		fixed (double* ptr = &equation)
		{
			Core.GetClipPlane(plane, ptr);
			equation = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetClipPlane(ClipPlaneName plane, [Out] double* equation)
	{
		Core.GetClipPlane(plane, equation);
	}

	public static void GetColorTable(ColorTableTarget target, PixelFormat format, PixelType type, [Out] IntPtr table)
	{
		Core.GetColorTable(target, format, type, table);
	}

	public static void GetColorTable<T3>(ColorTableTarget target, PixelFormat format, PixelType type, [In][Out] T3[] table) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(table, GCHandleType.Pinned);
		try
		{
			Core.GetColorTable(target, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetColorTable<T3>(ColorTableTarget target, PixelFormat format, PixelType type, [In][Out] T3[,] table) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(table, GCHandleType.Pinned);
		try
		{
			Core.GetColorTable(target, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetColorTable<T3>(ColorTableTarget target, PixelFormat format, PixelType type, [In][Out] T3[,,] table) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(table, GCHandleType.Pinned);
		try
		{
			Core.GetColorTable(target, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetColorTable<T3>(ColorTableTarget target, PixelFormat format, PixelType type, [In][Out] ref T3 table) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(table, GCHandleType.Pinned);
		try
		{
			Core.GetColorTable(target, format, type, gCHandle.AddrOfPinnedObject());
			table = (T3)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public unsafe static void GetColorTableParameter(ColorTableTarget target, GetColorTableParameterPName pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetColorTableParameterfv(target, pname, params2);
		}
	}

	public unsafe static void GetColorTableParameter(ColorTableTarget target, GetColorTableParameterPName pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetColorTableParameterfv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetColorTableParameter(ColorTableTarget target, GetColorTableParameterPName pname, [Out] float* @params)
	{
		Core.GetColorTableParameterfv(target, pname, @params);
	}

	public unsafe static void GetColorTableParameter(ColorTableTarget target, GetColorTableParameterPName pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetColorTableParameteriv(target, pname, params2);
		}
	}

	public unsafe static void GetColorTableParameter(ColorTableTarget target, GetColorTableParameterPName pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetColorTableParameteriv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetColorTableParameter(ColorTableTarget target, GetColorTableParameterPName pname, [Out] int* @params)
	{
		Core.GetColorTableParameteriv(target, pname, @params);
	}

	public static void GetCompressedTexImage(TextureTarget target, int level, [Out] IntPtr img)
	{
		Core.GetCompressedTexImage(target, level, img);
	}

	public static void GetConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, [Out] IntPtr image)
	{
		Core.GetConvolutionFilter(target, format, type, image);
	}

	public static void GetConvolutionFilter<T3>(ConvolutionTarget target, PixelFormat format, PixelType type, [In][Out] T3[] image) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.GetConvolutionFilter(target, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetConvolutionFilter<T3>(ConvolutionTarget target, PixelFormat format, PixelType type, [In][Out] T3[,] image) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.GetConvolutionFilter(target, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetConvolutionFilter<T3>(ConvolutionTarget target, PixelFormat format, PixelType type, [In][Out] T3[,,] image) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.GetConvolutionFilter(target, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetConvolutionFilter<T3>(ConvolutionTarget target, PixelFormat format, PixelType type, [In][Out] ref T3 image) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(image, GCHandleType.Pinned);
		try
		{
			Core.GetConvolutionFilter(target, format, type, gCHandle.AddrOfPinnedObject());
			image = (T3)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public unsafe static void GetConvolutionParameter(ConvolutionTarget target, GetConvolutionParameterPName pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetConvolutionParameterfv(target, pname, params2);
		}
	}

	public unsafe static void GetConvolutionParameter(ConvolutionTarget target, GetConvolutionParameterPName pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetConvolutionParameterfv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetConvolutionParameter(ConvolutionTarget target, GetConvolutionParameterPName pname, [Out] float* @params)
	{
		Core.GetConvolutionParameterfv(target, pname, @params);
	}

	public unsafe static void GetConvolutionParameter(ConvolutionTarget target, GetConvolutionParameterPName pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetConvolutionParameteriv(target, pname, params2);
		}
	}

	public unsafe static void GetConvolutionParameter(ConvolutionTarget target, GetConvolutionParameterPName pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetConvolutionParameteriv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetConvolutionParameter(ConvolutionTarget target, GetConvolutionParameterPName pname, [Out] int* @params)
	{
		Core.GetConvolutionParameteriv(target, pname, @params);
	}

	public unsafe static void GetDouble(GetIndexedPName target, int index, [Out] double[] data)
	{
		fixed (double* data2 = data)
		{
			Core.GetDoublei_v(target, (uint)index, data2);
		}
	}

	public unsafe static void GetDouble(GetIndexedPName target, int index, out double data)
	{
		fixed (double* ptr = &data)
		{
			Core.GetDoublei_v(target, (uint)index, ptr);
			data = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetDouble(GetIndexedPName target, int index, [Out] double* data)
	{
		Core.GetDoublei_v(target, (uint)index, data);
	}

	[CLSCompliant(false)]
	public unsafe static void GetDouble(GetIndexedPName target, uint index, [Out] double[] data)
	{
		fixed (double* data2 = data)
		{
			Core.GetDoublei_v(target, index, data2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetDouble(GetIndexedPName target, uint index, out double data)
	{
		fixed (double* ptr = &data)
		{
			Core.GetDoublei_v(target, index, ptr);
			data = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetDouble(GetIndexedPName target, uint index, [Out] double* data)
	{
		Core.GetDoublei_v(target, index, data);
	}

	public unsafe static void GetDouble(GetPName pname, [Out] double[] @params)
	{
		fixed (double* params2 = @params)
		{
			Core.GetDoublev(pname, params2);
		}
	}

	public unsafe static void GetDouble(GetPName pname, out double @params)
	{
		fixed (double* ptr = &@params)
		{
			Core.GetDoublev(pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetDouble(GetPName pname, [Out] double* @params)
	{
		Core.GetDoublev(pname, @params);
	}

	public static ErrorCode GetError()
	{
		return Core.GetError();
	}

	public unsafe static void GetFloat(GetIndexedPName target, int index, [Out] float[] data)
	{
		fixed (float* data2 = data)
		{
			Core.GetFloati_v(target, (uint)index, data2);
		}
	}

	public unsafe static void GetFloat(GetIndexedPName target, int index, out float data)
	{
		fixed (float* ptr = &data)
		{
			Core.GetFloati_v(target, (uint)index, ptr);
			data = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetFloat(GetIndexedPName target, int index, [Out] float* data)
	{
		Core.GetFloati_v(target, (uint)index, data);
	}

	[CLSCompliant(false)]
	public unsafe static void GetFloat(GetIndexedPName target, uint index, [Out] float[] data)
	{
		fixed (float* data2 = data)
		{
			Core.GetFloati_v(target, index, data2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetFloat(GetIndexedPName target, uint index, out float data)
	{
		fixed (float* ptr = &data)
		{
			Core.GetFloati_v(target, index, ptr);
			data = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetFloat(GetIndexedPName target, uint index, [Out] float* data)
	{
		Core.GetFloati_v(target, index, data);
	}

	public unsafe static void GetFloat(GetPName pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetFloatv(pname, params2);
		}
	}

	public unsafe static void GetFloat(GetPName pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetFloatv(pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetFloat(GetPName pname, [Out] float* @params)
	{
		Core.GetFloatv(pname, @params);
	}

	public static void GetHistogram(HistogramTarget target, bool reset, PixelFormat format, PixelType type, [Out] IntPtr values)
	{
		Core.GetHistogram(target, reset, format, type, values);
	}

	public static void GetHistogram<T4>(HistogramTarget target, bool reset, PixelFormat format, PixelType type, [In][Out] T4[] values) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(values, GCHandleType.Pinned);
		try
		{
			Core.GetHistogram(target, reset, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetHistogram<T4>(HistogramTarget target, bool reset, PixelFormat format, PixelType type, [In][Out] T4[,] values) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(values, GCHandleType.Pinned);
		try
		{
			Core.GetHistogram(target, reset, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetHistogram<T4>(HistogramTarget target, bool reset, PixelFormat format, PixelType type, [In][Out] T4[,,] values) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(values, GCHandleType.Pinned);
		try
		{
			Core.GetHistogram(target, reset, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetHistogram<T4>(HistogramTarget target, bool reset, PixelFormat format, PixelType type, [In][Out] ref T4 values) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(values, GCHandleType.Pinned);
		try
		{
			Core.GetHistogram(target, reset, format, type, gCHandle.AddrOfPinnedObject());
			values = (T4)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public unsafe static void GetHistogramParameter(HistogramTarget target, GetHistogramParameterPName pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetHistogramParameterfv(target, pname, params2);
		}
	}

	public unsafe static void GetHistogramParameter(HistogramTarget target, GetHistogramParameterPName pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetHistogramParameterfv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetHistogramParameter(HistogramTarget target, GetHistogramParameterPName pname, [Out] float* @params)
	{
		Core.GetHistogramParameterfv(target, pname, @params);
	}

	public unsafe static void GetHistogramParameter(HistogramTarget target, GetHistogramParameterPName pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetHistogramParameteriv(target, pname, params2);
		}
	}

	public unsafe static void GetHistogramParameter(HistogramTarget target, GetHistogramParameterPName pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetHistogramParameteriv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetHistogramParameter(HistogramTarget target, GetHistogramParameterPName pname, [Out] int* @params)
	{
		Core.GetHistogramParameteriv(target, pname, @params);
	}

	public unsafe static void GetInteger(GetPName pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetIntegerv(pname, params2);
		}
	}

	public unsafe static void GetInteger(GetPName pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetIntegerv(pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetInteger(GetPName pname, [Out] int* @params)
	{
		Core.GetIntegerv(pname, @params);
	}

	public unsafe static void GetLight(LightName light, LightParameter pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetLightfv(light, pname, params2);
		}
	}

	public unsafe static void GetLight(LightName light, LightParameter pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetLightfv(light, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetLight(LightName light, LightParameter pname, [Out] float* @params)
	{
		Core.GetLightfv(light, pname, @params);
	}

	public unsafe static void GetLight(LightName light, LightParameter pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetLightiv(light, pname, params2);
		}
	}

	public unsafe static void GetLight(LightName light, LightParameter pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetLightiv(light, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetLight(LightName light, LightParameter pname, [Out] int* @params)
	{
		Core.GetLightiv(light, pname, @params);
	}

	public unsafe static void GetMap(MapTarget target, GetMapQuery query, [Out] double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.GetMapdv(target, query, v2);
		}
	}

	public unsafe static void GetMap(MapTarget target, GetMapQuery query, out double v)
	{
		fixed (double* ptr = &v)
		{
			Core.GetMapdv(target, query, ptr);
			v = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetMap(MapTarget target, GetMapQuery query, [Out] double* v)
	{
		Core.GetMapdv(target, query, v);
	}

	public unsafe static void GetMap(MapTarget target, GetMapQuery query, [Out] float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.GetMapfv(target, query, v2);
		}
	}

	public unsafe static void GetMap(MapTarget target, GetMapQuery query, out float v)
	{
		fixed (float* ptr = &v)
		{
			Core.GetMapfv(target, query, ptr);
			v = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetMap(MapTarget target, GetMapQuery query, [Out] float* v)
	{
		Core.GetMapfv(target, query, v);
	}

	public unsafe static void GetMap(MapTarget target, GetMapQuery query, [Out] int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.GetMapiv(target, query, v2);
		}
	}

	public unsafe static void GetMap(MapTarget target, GetMapQuery query, out int v)
	{
		fixed (int* ptr = &v)
		{
			Core.GetMapiv(target, query, ptr);
			v = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetMap(MapTarget target, GetMapQuery query, [Out] int* v)
	{
		Core.GetMapiv(target, query, v);
	}

	public unsafe static void GetMaterial(MaterialFace face, MaterialParameter pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetMaterialfv(face, pname, params2);
		}
	}

	public unsafe static void GetMaterial(MaterialFace face, MaterialParameter pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetMaterialfv(face, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetMaterial(MaterialFace face, MaterialParameter pname, [Out] float* @params)
	{
		Core.GetMaterialfv(face, pname, @params);
	}

	public unsafe static void GetMaterial(MaterialFace face, MaterialParameter pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetMaterialiv(face, pname, params2);
		}
	}

	public unsafe static void GetMaterial(MaterialFace face, MaterialParameter pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetMaterialiv(face, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetMaterial(MaterialFace face, MaterialParameter pname, [Out] int* @params)
	{
		Core.GetMaterialiv(face, pname, @params);
	}

	public static void GetMinmax(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, [Out] IntPtr values)
	{
		Core.GetMinmax(target, reset, format, type, values);
	}

	public static void GetMinmax<T4>(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, [In][Out] T4[] values) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(values, GCHandleType.Pinned);
		try
		{
			Core.GetMinmax(target, reset, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetMinmax<T4>(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, [In][Out] T4[,] values) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(values, GCHandleType.Pinned);
		try
		{
			Core.GetMinmax(target, reset, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetMinmax<T4>(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, [In][Out] T4[,,] values) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(values, GCHandleType.Pinned);
		try
		{
			Core.GetMinmax(target, reset, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetMinmax<T4>(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, [In][Out] ref T4 values) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(values, GCHandleType.Pinned);
		try
		{
			Core.GetMinmax(target, reset, format, type, gCHandle.AddrOfPinnedObject());
			values = (T4)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public unsafe static void GetMinmaxParameter(MinmaxTarget target, GetMinmaxParameterPName pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetMinmaxParameterfv(target, pname, params2);
		}
	}

	public unsafe static void GetMinmaxParameter(MinmaxTarget target, GetMinmaxParameterPName pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetMinmaxParameterfv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetMinmaxParameter(MinmaxTarget target, GetMinmaxParameterPName pname, [Out] float* @params)
	{
		Core.GetMinmaxParameterfv(target, pname, @params);
	}

	public unsafe static void GetMinmaxParameter(MinmaxTarget target, GetMinmaxParameterPName pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetMinmaxParameteriv(target, pname, params2);
		}
	}

	public unsafe static void GetMinmaxParameter(MinmaxTarget target, GetMinmaxParameterPName pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetMinmaxParameteriv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetMinmaxParameter(MinmaxTarget target, GetMinmaxParameterPName pname, [Out] int* @params)
	{
		Core.GetMinmaxParameteriv(target, pname, @params);
	}

	public unsafe static void GetPixelMap(PixelMap map, [Out] float[] values)
	{
		fixed (float* values2 = values)
		{
			Core.GetPixelMapfv(map, values2);
		}
	}

	public unsafe static void GetPixelMap(PixelMap map, out float values)
	{
		fixed (float* ptr = &values)
		{
			Core.GetPixelMapfv(map, ptr);
			values = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetPixelMap(PixelMap map, [Out] float* values)
	{
		Core.GetPixelMapfv(map, values);
	}

	public unsafe static void GetPixelMap(PixelMap map, [Out] int[] values)
	{
		fixed (int* values2 = values)
		{
			Core.GetPixelMapuiv(map, (uint*)values2);
		}
	}

	public unsafe static void GetPixelMap(PixelMap map, out int values)
	{
		fixed (int* ptr = &values)
		{
			Core.GetPixelMapuiv(map, (uint*)ptr);
			values = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetPixelMap(PixelMap map, [Out] int* values)
	{
		Core.GetPixelMapuiv(map, (uint*)values);
	}

	[CLSCompliant(false)]
	public unsafe static void GetPixelMap(PixelMap map, [Out] uint[] values)
	{
		fixed (uint* values2 = values)
		{
			Core.GetPixelMapuiv(map, values2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetPixelMap(PixelMap map, out uint values)
	{
		fixed (uint* ptr = &values)
		{
			Core.GetPixelMapuiv(map, ptr);
			values = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetPixelMap(PixelMap map, [Out] uint* values)
	{
		Core.GetPixelMapuiv(map, values);
	}

	public unsafe static void GetPixelMap(PixelMap map, [Out] short[] values)
	{
		fixed (short* values2 = values)
		{
			Core.GetPixelMapusv(map, (ushort*)values2);
		}
	}

	public unsafe static void GetPixelMap(PixelMap map, out short values)
	{
		fixed (short* ptr = &values)
		{
			Core.GetPixelMapusv(map, (ushort*)ptr);
			values = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetPixelMap(PixelMap map, [Out] short* values)
	{
		Core.GetPixelMapusv(map, (ushort*)values);
	}

	[CLSCompliant(false)]
	public unsafe static void GetPixelMap(PixelMap map, [Out] ushort[] values)
	{
		fixed (ushort* values2 = values)
		{
			Core.GetPixelMapusv(map, values2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetPixelMap(PixelMap map, out ushort values)
	{
		fixed (ushort* ptr = &values)
		{
			Core.GetPixelMapusv(map, ptr);
			values = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetPixelMap(PixelMap map, [Out] ushort* values)
	{
		Core.GetPixelMapusv(map, values);
	}

	public static void GetPointer(GetPointervPName pname, [Out] IntPtr @params)
	{
		Core.GetPointerv(pname, @params);
	}

	public static void GetPointer<T1>(GetPointervPName pname, [In][Out] T1[] @params) where T1 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(@params, GCHandleType.Pinned);
		try
		{
			Core.GetPointerv(pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetPointer<T1>(GetPointervPName pname, [In][Out] T1[,] @params) where T1 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(@params, GCHandleType.Pinned);
		try
		{
			Core.GetPointerv(pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetPointer<T1>(GetPointervPName pname, [In][Out] T1[,,] @params) where T1 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(@params, GCHandleType.Pinned);
		try
		{
			Core.GetPointerv(pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetPointer<T1>(GetPointervPName pname, [In][Out] ref T1 @params) where T1 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(@params, GCHandleType.Pinned);
		try
		{
			Core.GetPointerv(pname, gCHandle.AddrOfPinnedObject());
			@params = (T1)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public unsafe static void GetPolygonStipple([Out] byte[] mask)
	{
		fixed (byte* mask2 = mask)
		{
			Core.GetPolygonStipple(mask2);
		}
	}

	public unsafe static void GetPolygonStipple(out byte mask)
	{
		fixed (byte* ptr = &mask)
		{
			Core.GetPolygonStipple(ptr);
			mask = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetPolygonStipple([Out] byte* mask)
	{
		Core.GetPolygonStipple(mask);
	}

	public unsafe static void GetProgramInfoLog(int program, int bufSize, out int length, [Out] StringBuilder infoLog)
	{
		fixed (int* ptr = &length)
		{
			Core.GetProgramInfoLog((uint)program, bufSize, ptr, infoLog);
			length = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetProgramInfoLog(int program, int bufSize, [Out] int* length, [Out] StringBuilder infoLog)
	{
		Core.GetProgramInfoLog((uint)program, bufSize, length, infoLog);
	}

	[CLSCompliant(false)]
	public unsafe static void GetProgramInfoLog(uint program, int bufSize, out int length, [Out] StringBuilder infoLog)
	{
		fixed (int* ptr = &length)
		{
			Core.GetProgramInfoLog(program, bufSize, ptr, infoLog);
			length = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetProgramInfoLog(uint program, int bufSize, [Out] int* length, [Out] StringBuilder infoLog)
	{
		Core.GetProgramInfoLog(program, bufSize, length, infoLog);
	}

	public unsafe static void GetProgram(int program, ProgramParameter pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetProgramiv((uint)program, pname, params2);
		}
	}

	public unsafe static void GetProgram(int program, ProgramParameter pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetProgramiv((uint)program, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetProgram(int program, ProgramParameter pname, [Out] int* @params)
	{
		Core.GetProgramiv((uint)program, pname, @params);
	}

	[CLSCompliant(false)]
	public unsafe static void GetProgram(uint program, ProgramParameter pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetProgramiv(program, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetProgram(uint program, ProgramParameter pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetProgramiv(program, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetProgram(uint program, ProgramParameter pname, [Out] int* @params)
	{
		Core.GetProgramiv(program, pname, @params);
	}

	public static void GetSeparableFilter(SeparableTarget target, PixelFormat format, PixelType type, [Out] IntPtr row, [Out] IntPtr column, [Out] IntPtr span)
	{
		Core.GetSeparableFilter(target, format, type, row, column, span);
	}

	public static void GetSeparableFilter<T5>(SeparableTarget target, PixelFormat format, PixelType type, [Out] IntPtr row, [Out] IntPtr column, [In][Out] T5[] span) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, row, column, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetSeparableFilter<T5>(SeparableTarget target, PixelFormat format, PixelType type, [Out] IntPtr row, [Out] IntPtr column, [In][Out] T5[,] span) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, row, column, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetSeparableFilter<T5>(SeparableTarget target, PixelFormat format, PixelType type, [Out] IntPtr row, [Out] IntPtr column, [In][Out] T5[,,] span) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, row, column, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetSeparableFilter<T5>(SeparableTarget target, PixelFormat format, PixelType type, [Out] IntPtr row, [Out] IntPtr column, [In][Out] ref T5 span) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, row, column, gCHandle.AddrOfPinnedObject());
			span = (T5)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetSeparableFilter<T4, T5>(SeparableTarget target, PixelFormat format, PixelType type, [Out] IntPtr row, [In][Out] T4[] column, [In][Out] T5[,,] span) where T4 : struct where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(column, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, row, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
		}
	}

	public static void GetSeparableFilter<T4, T5>(SeparableTarget target, PixelFormat format, PixelType type, [Out] IntPtr row, [In][Out] T4[,] column, [In][Out] T5[,,] span) where T4 : struct where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(column, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, row, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
		}
	}

	public static void GetSeparableFilter<T4, T5>(SeparableTarget target, PixelFormat format, PixelType type, [Out] IntPtr row, [In][Out] T4[,,] column, [In][Out] T5[,,] span) where T4 : struct where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(column, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, row, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
		}
	}

	public static void GetSeparableFilter<T4, T5>(SeparableTarget target, PixelFormat format, PixelType type, [Out] IntPtr row, [In][Out] ref T4 column, [In][Out] T5[,,] span) where T4 : struct where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(column, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, row, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject());
			column = (T4)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
		}
	}

	public static void GetSeparableFilter<T3, T4, T5>(SeparableTarget target, PixelFormat format, PixelType type, [In][Out] T3[] row, [In][Out] T4[,,] column, [In][Out] T5[,,] span) where T3 : struct where T4 : struct where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(row, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(column, GCHandleType.Pinned);
		GCHandle gCHandle3 = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject(), gCHandle3.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
			gCHandle3.Free();
		}
	}

	public static void GetSeparableFilter<T3, T4, T5>(SeparableTarget target, PixelFormat format, PixelType type, [In][Out] T3[,] row, [In][Out] T4[,,] column, [In][Out] T5[,,] span) where T3 : struct where T4 : struct where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(row, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(column, GCHandleType.Pinned);
		GCHandle gCHandle3 = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject(), gCHandle3.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
			gCHandle3.Free();
		}
	}

	public static void GetSeparableFilter<T3, T4, T5>(SeparableTarget target, PixelFormat format, PixelType type, [In][Out] T3[,,] row, [In][Out] T4[,,] column, [In][Out] T5[,,] span) where T3 : struct where T4 : struct where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(row, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(column, GCHandleType.Pinned);
		GCHandle gCHandle3 = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject(), gCHandle3.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
			gCHandle3.Free();
		}
	}

	public static void GetSeparableFilter<T3, T4, T5>(SeparableTarget target, PixelFormat format, PixelType type, [In][Out] ref T3 row, [In][Out] T4[,,] column, [In][Out] T5[,,] span) where T3 : struct where T4 : struct where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(row, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(column, GCHandleType.Pinned);
		GCHandle gCHandle3 = GCHandle.Alloc(span, GCHandleType.Pinned);
		try
		{
			Core.GetSeparableFilter(target, format, type, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject(), gCHandle3.AddrOfPinnedObject());
			row = (T3)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
			gCHandle3.Free();
		}
	}

	public unsafe static void GetShaderInfoLog(int shader, int bufSize, out int length, [Out] StringBuilder infoLog)
	{
		fixed (int* ptr = &length)
		{
			Core.GetShaderInfoLog((uint)shader, bufSize, ptr, infoLog);
			length = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetShaderInfoLog(int shader, int bufSize, [Out] int* length, [Out] StringBuilder infoLog)
	{
		Core.GetShaderInfoLog((uint)shader, bufSize, length, infoLog);
	}

	[CLSCompliant(false)]
	public unsafe static void GetShaderInfoLog(uint shader, int bufSize, out int length, [Out] StringBuilder infoLog)
	{
		fixed (int* ptr = &length)
		{
			Core.GetShaderInfoLog(shader, bufSize, ptr, infoLog);
			length = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetShaderInfoLog(uint shader, int bufSize, [Out] int* length, [Out] StringBuilder infoLog)
	{
		Core.GetShaderInfoLog(shader, bufSize, length, infoLog);
	}

	public unsafe static void GetShader(int shader, ShaderParameter pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetShaderiv((uint)shader, pname, params2);
		}
	}

	public unsafe static void GetShader(int shader, ShaderParameter pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetShaderiv((uint)shader, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetShader(int shader, ShaderParameter pname, [Out] int* @params)
	{
		Core.GetShaderiv((uint)shader, pname, @params);
	}

	[CLSCompliant(false)]
	public unsafe static void GetShader(uint shader, ShaderParameter pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetShaderiv(shader, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetShader(uint shader, ShaderParameter pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetShaderiv(shader, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetShader(uint shader, ShaderParameter pname, [Out] int* @params)
	{
		Core.GetShaderiv(shader, pname, @params);
	}

	public unsafe static void GetShaderSource(int shader, int bufSize, out int length, [Out] StringBuilder source)
	{
		fixed (int* ptr = &length)
		{
			Core.GetShaderSource((uint)shader, bufSize, ptr, source);
			length = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetShaderSource(int shader, int bufSize, [Out] int* length, [Out] StringBuilder source)
	{
		Core.GetShaderSource((uint)shader, bufSize, length, source);
	}

	[CLSCompliant(false)]
	public unsafe static void GetShaderSource(uint shader, int bufSize, out int length, [Out] StringBuilder source)
	{
		fixed (int* ptr = &length)
		{
			Core.GetShaderSource(shader, bufSize, ptr, source);
			length = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetShaderSource(uint shader, int bufSize, [Out] int* length, [Out] StringBuilder source)
	{
		Core.GetShaderSource(shader, bufSize, length, source);
	}

	public unsafe static string GetString(StringName name)
	{
		return new string((sbyte*)(void*)Core.GetString(name));
	}

	public unsafe static string GetString(StringName name, int index)
	{
		return new string((sbyte*)(void*)Core.GetStringi(name, (uint)index));
	}

	[CLSCompliant(false)]
	public unsafe static string GetString(StringName name, uint index)
	{
		return new string((sbyte*)(void*)Core.GetStringi(name, index));
	}

	public unsafe static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetTexEnvfv(target, pname, params2);
		}
	}

	public unsafe static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetTexEnvfv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, [Out] float* @params)
	{
		Core.GetTexEnvfv(target, pname, @params);
	}

	public unsafe static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetTexEnviv(target, pname, params2);
		}
	}

	public unsafe static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetTexEnviv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, [Out] int* @params)
	{
		Core.GetTexEnviv(target, pname, @params);
	}

	public unsafe static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] double[] @params)
	{
		fixed (double* params2 = @params)
		{
			Core.GetTexGendv(coord, pname, params2);
		}
	}

	public unsafe static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, out double @params)
	{
		fixed (double* ptr = &@params)
		{
			Core.GetTexGendv(coord, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] double* @params)
	{
		Core.GetTexGendv(coord, pname, @params);
	}

	public unsafe static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetTexGenfv(coord, pname, params2);
		}
	}

	public unsafe static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetTexGenfv(coord, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] float* @params)
	{
		Core.GetTexGenfv(coord, pname, @params);
	}

	public unsafe static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetTexGeniv(coord, pname, params2);
		}
	}

	public unsafe static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetTexGeniv(coord, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] int* @params)
	{
		Core.GetTexGeniv(coord, pname, @params);
	}

	public static void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, [Out] IntPtr pixels)
	{
		Core.GetTexImage(target, level, format, type, pixels);
	}

	public static void GetTexImage<T4>(TextureTarget target, int level, PixelFormat format, PixelType type, [In][Out] T4[] pixels) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.GetTexImage(target, level, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetTexImage<T4>(TextureTarget target, int level, PixelFormat format, PixelType type, [In][Out] T4[,] pixels) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.GetTexImage(target, level, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetTexImage<T4>(TextureTarget target, int level, PixelFormat format, PixelType type, [In][Out] T4[,,] pixels) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.GetTexImage(target, level, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetTexImage<T4>(TextureTarget target, int level, PixelFormat format, PixelType type, [In][Out] ref T4 pixels) where T4 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.GetTexImage(target, level, format, type, gCHandle.AddrOfPinnedObject());
			pixels = (T4)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public unsafe static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetTexLevelParameterfv(target, level, pname, params2);
		}
	}

	public unsafe static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetTexLevelParameterfv(target, level, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, [Out] float* @params)
	{
		Core.GetTexLevelParameterfv(target, level, pname, @params);
	}

	public unsafe static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetTexLevelParameteriv(target, level, pname, params2);
		}
	}

	public unsafe static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetTexLevelParameteriv(target, level, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, [Out] int* @params)
	{
		Core.GetTexLevelParameteriv(target, level, pname, @params);
	}

	public unsafe static void GetTexParameter(TextureTarget target, GetTextureParameter pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetTexParameterfv(target, pname, params2);
		}
	}

	public unsafe static void GetTexParameter(TextureTarget target, GetTextureParameter pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetTexParameterfv(target, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetTexParameter(TextureTarget target, GetTextureParameter pname, [Out] float* @params)
	{
		Core.GetTexParameterfv(target, pname, @params);
	}

	public unsafe static void GetUniform(int program, int location, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetUniformfv((uint)program, location, params2);
		}
	}

	public unsafe static void GetUniform(int program, int location, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetUniformfv((uint)program, location, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetUniform(int program, int location, [Out] float* @params)
	{
		Core.GetUniformfv((uint)program, location, @params);
	}

	[CLSCompliant(false)]
	public unsafe static void GetUniform(uint program, int location, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetUniformfv(program, location, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetUniform(uint program, int location, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetUniformfv(program, location, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetUniform(uint program, int location, [Out] float* @params)
	{
		Core.GetUniformfv(program, location, @params);
	}

	public unsafe static void GetUniform(int program, int location, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetUniformiv((uint)program, location, params2);
		}
	}

	public unsafe static void GetUniform(int program, int location, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetUniformiv((uint)program, location, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetUniform(int program, int location, [Out] int* @params)
	{
		Core.GetUniformiv((uint)program, location, @params);
	}

	[CLSCompliant(false)]
	public unsafe static void GetUniform(uint program, int location, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetUniformiv(program, location, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetUniform(uint program, int location, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetUniformiv(program, location, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetUniform(uint program, int location, [Out] int* @params)
	{
		Core.GetUniformiv(program, location, @params);
	}

	public static int GetUniformLocation(int program, string name)
	{
		return Core.GetUniformLocation((uint)program, name);
	}

	[CLSCompliant(false)]
	public static int GetUniformLocation(uint program, string name)
	{
		return Core.GetUniformLocation(program, name);
	}

	public unsafe static void GetVertexAttrib(int index, VertexAttribParameter pname, [Out] double[] @params)
	{
		fixed (double* params2 = @params)
		{
			Core.GetVertexAttribdv((uint)index, pname, params2);
		}
	}

	public unsafe static void GetVertexAttrib(int index, VertexAttribParameter pname, out double @params)
	{
		fixed (double* ptr = &@params)
		{
			Core.GetVertexAttribdv((uint)index, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(int index, VertexAttribParameter pname, [Out] double* @params)
	{
		Core.GetVertexAttribdv((uint)index, pname, @params);
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(uint index, VertexAttribParameter pname, [Out] double[] @params)
	{
		fixed (double* params2 = @params)
		{
			Core.GetVertexAttribdv(index, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(uint index, VertexAttribParameter pname, out double @params)
	{
		fixed (double* ptr = &@params)
		{
			Core.GetVertexAttribdv(index, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(uint index, VertexAttribParameter pname, [Out] double* @params)
	{
		Core.GetVertexAttribdv(index, pname, @params);
	}

	public unsafe static void GetVertexAttrib(int index, VertexAttribParameter pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetVertexAttribfv((uint)index, pname, params2);
		}
	}

	public unsafe static void GetVertexAttrib(int index, VertexAttribParameter pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetVertexAttribfv((uint)index, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(int index, VertexAttribParameter pname, [Out] float* @params)
	{
		Core.GetVertexAttribfv((uint)index, pname, @params);
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(uint index, VertexAttribParameter pname, [Out] float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.GetVertexAttribfv(index, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(uint index, VertexAttribParameter pname, out float @params)
	{
		fixed (float* ptr = &@params)
		{
			Core.GetVertexAttribfv(index, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(uint index, VertexAttribParameter pname, [Out] float* @params)
	{
		Core.GetVertexAttribfv(index, pname, @params);
	}

	public unsafe static void GetVertexAttrib(int index, VertexAttribParameter pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetVertexAttribiv((uint)index, pname, params2);
		}
	}

	public unsafe static void GetVertexAttrib(int index, VertexAttribParameter pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetVertexAttribiv((uint)index, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(int index, VertexAttribParameter pname, [Out] int* @params)
	{
		Core.GetVertexAttribiv((uint)index, pname, @params);
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(uint index, VertexAttribParameter pname, [Out] int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.GetVertexAttribiv(index, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(uint index, VertexAttribParameter pname, out int @params)
	{
		fixed (int* ptr = &@params)
		{
			Core.GetVertexAttribiv(index, pname, ptr);
			@params = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void GetVertexAttrib(uint index, VertexAttribParameter pname, [Out] int* @params)
	{
		Core.GetVertexAttribiv(index, pname, @params);
	}

	public static void GetVertexAttribPointer(int index, VertexAttribPointerParameter pname, [Out] IntPtr pointer)
	{
		Core.GetVertexAttribPointerv((uint)index, pname, pointer);
	}

	public static void GetVertexAttribPointer<T2>(int index, VertexAttribPointerParameter pname, [In][Out] T2[] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.GetVertexAttribPointerv((uint)index, pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetVertexAttribPointer<T2>(int index, VertexAttribPointerParameter pname, [In][Out] T2[,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.GetVertexAttribPointerv((uint)index, pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetVertexAttribPointer<T2>(int index, VertexAttribPointerParameter pname, [In][Out] T2[,,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.GetVertexAttribPointerv((uint)index, pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void GetVertexAttribPointer<T2>(int index, VertexAttribPointerParameter pname, [In][Out] ref T2 pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.GetVertexAttribPointerv((uint)index, pname, gCHandle.AddrOfPinnedObject());
			pointer = (T2)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void GetVertexAttribPointer(uint index, VertexAttribPointerParameter pname, [Out] IntPtr pointer)
	{
		Core.GetVertexAttribPointerv(index, pname, pointer);
	}

	[CLSCompliant(false)]
	public static void GetVertexAttribPointer<T2>(uint index, VertexAttribPointerParameter pname, [In][Out] T2[] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.GetVertexAttribPointerv(index, pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void GetVertexAttribPointer<T2>(uint index, VertexAttribPointerParameter pname, [In][Out] T2[,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.GetVertexAttribPointerv(index, pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void GetVertexAttribPointer<T2>(uint index, VertexAttribPointerParameter pname, [In][Out] T2[,,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.GetVertexAttribPointerv(index, pname, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void GetVertexAttribPointer<T2>(uint index, VertexAttribPointerParameter pname, [In][Out] ref T2 pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.GetVertexAttribPointerv(index, pname, gCHandle.AddrOfPinnedObject());
			pointer = (T2)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void Hint(HintTarget target, HintMode mode)
	{
		Core.Hint(target, mode);
	}

	public static void Histogram(HistogramTarget target, int width, PixelInternalFormat internalformat, bool sink)
	{
		Core.Histogram(target, width, internalformat, sink);
	}

	public static void Index(double c)
	{
		Core.Indexd(c);
	}

	[CLSCompliant(false)]
	public unsafe static void Index(double* c)
	{
		Core.Indexdv(c);
	}

	public static void Index(float c)
	{
		Core.Indexf(c);
	}

	[CLSCompliant(false)]
	public unsafe static void Index(float* c)
	{
		Core.Indexfv(c);
	}

	public static void Index(int c)
	{
		Core.Indexi(c);
	}

	[CLSCompliant(false)]
	public unsafe static void Index(int* c)
	{
		Core.Indexiv(c);
	}

	public static void IndexMask(int mask)
	{
		Core.IndexMask((uint)mask);
	}

	[CLSCompliant(false)]
	public static void IndexMask(uint mask)
	{
		Core.IndexMask(mask);
	}

	public static void IndexPointer(IndexPointerType type, int stride, IntPtr pointer)
	{
		Core.IndexPointer(type, stride, pointer);
	}

	public static void IndexPointer<T2>(IndexPointerType type, int stride, [In][Out] T2[] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.IndexPointer(type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void IndexPointer<T2>(IndexPointerType type, int stride, [In][Out] T2[,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.IndexPointer(type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void IndexPointer<T2>(IndexPointerType type, int stride, [In][Out] T2[,,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.IndexPointer(type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void IndexPointer<T2>(IndexPointerType type, int stride, [In][Out] ref T2 pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.IndexPointer(type, stride, gCHandle.AddrOfPinnedObject());
			pointer = (T2)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void Index(short c)
	{
		Core.Indexs(c);
	}

	[CLSCompliant(false)]
	public unsafe static void Index(short* c)
	{
		Core.Indexsv(c);
	}

	public static void Index(byte c)
	{
		Core.Indexub(c);
	}

	[CLSCompliant(false)]
	public unsafe static void Index(byte* c)
	{
		Core.Indexubv(c);
	}

	public static void InitNames()
	{
		Core.InitNames();
	}

	public static void InterleavedArrays(InterleavedArrayFormat format, int stride, IntPtr pointer)
	{
		Core.InterleavedArrays(format, stride, pointer);
	}

	public static void InterleavedArrays<T2>(InterleavedArrayFormat format, int stride, [In][Out] T2[] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.InterleavedArrays(format, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void InterleavedArrays<T2>(InterleavedArrayFormat format, int stride, [In][Out] T2[,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.InterleavedArrays(format, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void InterleavedArrays<T2>(InterleavedArrayFormat format, int stride, [In][Out] T2[,,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.InterleavedArrays(format, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void InterleavedArrays<T2>(InterleavedArrayFormat format, int stride, [In][Out] ref T2 pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.InterleavedArrays(format, stride, gCHandle.AddrOfPinnedObject());
			pointer = (T2)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static bool IsBuffer(int buffer)
	{
		return Core.IsBuffer((uint)buffer);
	}

	[CLSCompliant(false)]
	public static bool IsBuffer(uint buffer)
	{
		return Core.IsBuffer(buffer);
	}

	public static bool IsEnabled(EnableCap cap)
	{
		return Core.IsEnabled(cap);
	}

	public static bool IsList(int list)
	{
		return Core.IsList((uint)list);
	}

	[CLSCompliant(false)]
	public static bool IsList(uint list)
	{
		return Core.IsList(list);
	}

	public static bool IsQuery(int id)
	{
		return Core.IsQuery((uint)id);
	}

	[CLSCompliant(false)]
	public static bool IsQuery(uint id)
	{
		return Core.IsQuery(id);
	}

	public static bool IsShader(int shader)
	{
		return Core.IsShader((uint)shader);
	}

	[CLSCompliant(false)]
	public static bool IsShader(uint shader)
	{
		return Core.IsShader(shader);
	}

	public static bool IsTexture(int texture)
	{
		return Core.IsTexture((uint)texture);
	}

	[CLSCompliant(false)]
	public static bool IsTexture(uint texture)
	{
		return Core.IsTexture(texture);
	}

	public static void Light(LightName light, LightParameter pname, float param)
	{
		Core.Lightf(light, pname, param);
	}

	public unsafe static void Light(LightName light, LightParameter pname, float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.Lightfv(light, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Light(LightName light, LightParameter pname, float* @params)
	{
		Core.Lightfv(light, pname, @params);
	}

	public static void Light(LightName light, LightParameter pname, int param)
	{
		Core.Lighti(light, pname, param);
	}

	public unsafe static void Light(LightName light, LightParameter pname, int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.Lightiv(light, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Light(LightName light, LightParameter pname, int* @params)
	{
		Core.Lightiv(light, pname, @params);
	}

	public static void LightModel(LightModelParameter pname, float param)
	{
		Core.LightModelf(pname, param);
	}

	public unsafe static void LightModel(LightModelParameter pname, float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.LightModelfv(pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void LightModel(LightModelParameter pname, float* @params)
	{
		Core.LightModelfv(pname, @params);
	}

	public static void LightModel(LightModelParameter pname, int param)
	{
		Core.LightModeli(pname, param);
	}

	public unsafe static void LightModel(LightModelParameter pname, int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.LightModeliv(pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void LightModel(LightModelParameter pname, int* @params)
	{
		Core.LightModeliv(pname, @params);
	}

	public static void LineStipple(int factor, short pattern)
	{
		Core.LineStipple(factor, (ushort)pattern);
	}

	[CLSCompliant(false)]
	public static void LineStipple(int factor, ushort pattern)
	{
		Core.LineStipple(factor, pattern);
	}

	public static void LineWidth(float width)
	{
		Core.LineWidth(width);
	}

	public static void LinkProgram(int program)
	{
		Core.LinkProgram((uint)program);
	}

	[CLSCompliant(false)]
	public static void LinkProgram(uint program)
	{
		Core.LinkProgram(program);
	}

	public static void ListBase(int @base)
	{
		Core.ListBase((uint)@base);
	}

	[CLSCompliant(false)]
	public static void ListBase(uint @base)
	{
		Core.ListBase(@base);
	}

	public static void LoadIdentity()
	{
		Core.LoadIdentity();
	}

	public unsafe static void LoadMatrix(double[] m)
	{
		fixed (double* m2 = m)
		{
			Core.LoadMatrixd(m2);
		}
	}

	public unsafe static void LoadMatrix(ref double m)
	{
		fixed (double* m2 = &m)
		{
			Core.LoadMatrixd(m2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void LoadMatrix(double* m)
	{
		Core.LoadMatrixd(m);
	}

	public unsafe static void LoadMatrix(float[] m)
	{
		fixed (float* m2 = m)
		{
			Core.LoadMatrixf(m2);
		}
	}

	public unsafe static void LoadMatrix(ref float m)
	{
		fixed (float* m2 = &m)
		{
			Core.LoadMatrixf(m2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void LoadMatrix(float* m)
	{
		Core.LoadMatrixf(m);
	}

	public static void LoadName(int name)
	{
		Core.LoadName((uint)name);
	}

	[CLSCompliant(false)]
	public static void LoadName(uint name)
	{
		Core.LoadName(name);
	}

	public unsafe static void LoadTransposeMatrix(double[] m)
	{
		fixed (double* m2 = m)
		{
			Core.LoadTransposeMatrixd(m2);
		}
	}

	public unsafe static void LoadTransposeMatrix(ref double m)
	{
		fixed (double* m2 = &m)
		{
			Core.LoadTransposeMatrixd(m2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void LoadTransposeMatrix(double* m)
	{
		Core.LoadTransposeMatrixd(m);
	}

	public unsafe static void LoadTransposeMatrix(float[] m)
	{
		fixed (float* m2 = m)
		{
			Core.LoadTransposeMatrixf(m2);
		}
	}

	public unsafe static void LoadTransposeMatrix(ref float m)
	{
		fixed (float* m2 = &m)
		{
			Core.LoadTransposeMatrixf(m2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void LoadTransposeMatrix(float* m)
	{
		Core.LoadTransposeMatrixf(m);
	}

	public static void LogicOp(LogicOp opcode)
	{
		Core.LogicOp(opcode);
	}

	public unsafe static void Map1(MapTarget target, double u1, double u2, int stride, int order, double[] points)
	{
		fixed (double* points2 = points)
		{
			Core.Map1d(target, u1, u2, stride, order, points2);
		}
	}

	public unsafe static void Map1(MapTarget target, double u1, double u2, int stride, int order, ref double points)
	{
		fixed (double* points2 = &points)
		{
			Core.Map1d(target, u1, u2, stride, order, points2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Map1(MapTarget target, double u1, double u2, int stride, int order, double* points)
	{
		Core.Map1d(target, u1, u2, stride, order, points);
	}

	public unsafe static void Map1(MapTarget target, float u1, float u2, int stride, int order, float[] points)
	{
		fixed (float* points2 = points)
		{
			Core.Map1f(target, u1, u2, stride, order, points2);
		}
	}

	public unsafe static void Map1(MapTarget target, float u1, float u2, int stride, int order, ref float points)
	{
		fixed (float* points2 = &points)
		{
			Core.Map1f(target, u1, u2, stride, order, points2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Map1(MapTarget target, float u1, float u2, int stride, int order, float* points)
	{
		Core.Map1f(target, u1, u2, stride, order, points);
	}

	public unsafe static void Map2(MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points)
	{
		fixed (double* points2 = points)
		{
			Core.Map2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points2);
		}
	}

	public unsafe static void Map2(MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, ref double points)
	{
		fixed (double* points2 = &points)
		{
			Core.Map2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Map2(MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points)
	{
		Core.Map2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
	}

	public unsafe static void Map2(MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points)
	{
		fixed (float* points2 = points)
		{
			Core.Map2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points2);
		}
	}

	public unsafe static void Map2(MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, ref float points)
	{
		fixed (float* points2 = &points)
		{
			Core.Map2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Map2(MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points)
	{
		Core.Map2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
	}

	[CLSCompliant(false)]
	public static IntPtr MapBuffer(BufferTarget target, BufferAccess access)
	{
		return Core.MapBuffer(target, access);
	}

	public static void MapGrid1(int un, double u1, double u2)
	{
		Core.MapGrid1d(un, u1, u2);
	}

	public static void MapGrid1(int un, float u1, float u2)
	{
		Core.MapGrid1f(un, u1, u2);
	}

	public static void MapGrid2(int un, double u1, double u2, int vn, double v1, double v2)
	{
		Core.MapGrid2d(un, u1, u2, vn, v1, v2);
	}

	public static void MapGrid2(int un, float u1, float u2, int vn, float v1, float v2)
	{
		Core.MapGrid2f(un, u1, u2, vn, v1, v2);
	}

	public static void Material(MaterialFace face, MaterialParameter pname, float param)
	{
		Core.Materialf(face, pname, param);
	}

	public unsafe static void Material(MaterialFace face, MaterialParameter pname, float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.Materialfv(face, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Material(MaterialFace face, MaterialParameter pname, float* @params)
	{
		Core.Materialfv(face, pname, @params);
	}

	public static void Material(MaterialFace face, MaterialParameter pname, int param)
	{
		Core.Materiali(face, pname, param);
	}

	public unsafe static void Material(MaterialFace face, MaterialParameter pname, int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.Materialiv(face, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Material(MaterialFace face, MaterialParameter pname, int* @params)
	{
		Core.Materialiv(face, pname, @params);
	}

	public static void MatrixMode(MatrixMode mode)
	{
		Core.MatrixMode(mode);
	}

	public static void Minmax(MinmaxTarget target, PixelInternalFormat internalformat, bool sink)
	{
		Core.Minmax(target, internalformat, sink);
	}

	public unsafe static void MultiDrawArrays(BeginMode mode, int[] first, int[] count, int primcount)
	{
		fixed (int* first2 = first)
		{
			fixed (int* count2 = count)
			{
				Core.MultiDrawArrays(mode, first2, count2, primcount);
			}
		}
	}

	public unsafe static void MultiDrawArrays(BeginMode mode, ref int first, ref int count, int primcount)
	{
		fixed (int* first2 = &first)
		{
			fixed (int* count2 = &count)
			{
				Core.MultiDrawArrays(mode, first2, count2, primcount);
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiDrawArrays(BeginMode mode, int* first, int* count, int primcount)
	{
		Core.MultiDrawArrays(mode, first, count, primcount);
	}

	public unsafe static void MultiDrawElements(BeginMode mode, int[] count, DrawElementsType type, IntPtr indices, int primcount)
	{
		fixed (int* count2 = count)
		{
			Core.MultiDrawElements(mode, count2, type, indices, primcount);
		}
	}

	public unsafe static void MultiDrawElements<T3>(BeginMode mode, int[] count, DrawElementsType type, [In][Out] T3[] indices, int primcount) where T3 : struct
	{
		fixed (int* count2 = count)
		{
			GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				Core.MultiDrawElements(mode, count2, type, gCHandle.AddrOfPinnedObject(), primcount);
			}
			finally
			{
				gCHandle.Free();
			}
		}
	}

	public unsafe static void MultiDrawElements<T3>(BeginMode mode, int[] count, DrawElementsType type, [In][Out] T3[,] indices, int primcount) where T3 : struct
	{
		fixed (int* count2 = count)
		{
			GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				Core.MultiDrawElements(mode, count2, type, gCHandle.AddrOfPinnedObject(), primcount);
			}
			finally
			{
				gCHandle.Free();
			}
		}
	}

	public unsafe static void MultiDrawElements<T3>(BeginMode mode, int[] count, DrawElementsType type, [In][Out] T3[,,] indices, int primcount) where T3 : struct
	{
		fixed (int* count2 = count)
		{
			GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				Core.MultiDrawElements(mode, count2, type, gCHandle.AddrOfPinnedObject(), primcount);
			}
			finally
			{
				gCHandle.Free();
			}
		}
	}

	public unsafe static void MultiDrawElements<T3>(BeginMode mode, int[] count, DrawElementsType type, [In][Out] ref T3 indices, int primcount) where T3 : struct
	{
		fixed (int* count2 = count)
		{
			GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				Core.MultiDrawElements(mode, count2, type, gCHandle.AddrOfPinnedObject(), primcount);
				indices = (T3)gCHandle.Target;
			}
			finally
			{
				gCHandle.Free();
			}
		}
	}

	public unsafe static void MultiDrawElements(BeginMode mode, ref int count, DrawElementsType type, IntPtr indices, int primcount)
	{
		fixed (int* count2 = &count)
		{
			Core.MultiDrawElements(mode, count2, type, indices, primcount);
		}
	}

	public unsafe static void MultiDrawElements<T3>(BeginMode mode, ref int count, DrawElementsType type, [In][Out] T3[] indices, int primcount) where T3 : struct
	{
		fixed (int* count2 = &count)
		{
			GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				Core.MultiDrawElements(mode, count2, type, gCHandle.AddrOfPinnedObject(), primcount);
			}
			finally
			{
				gCHandle.Free();
			}
		}
	}

	public unsafe static void MultiDrawElements<T3>(BeginMode mode, ref int count, DrawElementsType type, [In][Out] T3[,] indices, int primcount) where T3 : struct
	{
		fixed (int* count2 = &count)
		{
			GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				Core.MultiDrawElements(mode, count2, type, gCHandle.AddrOfPinnedObject(), primcount);
			}
			finally
			{
				gCHandle.Free();
			}
		}
	}

	public unsafe static void MultiDrawElements<T3>(BeginMode mode, ref int count, DrawElementsType type, [In][Out] T3[,,] indices, int primcount) where T3 : struct
	{
		fixed (int* count2 = &count)
		{
			GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				Core.MultiDrawElements(mode, count2, type, gCHandle.AddrOfPinnedObject(), primcount);
			}
			finally
			{
				gCHandle.Free();
			}
		}
	}

	public unsafe static void MultiDrawElements<T3>(BeginMode mode, ref int count, DrawElementsType type, [In][Out] ref T3 indices, int primcount) where T3 : struct
	{
		fixed (int* count2 = &count)
		{
			GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				Core.MultiDrawElements(mode, count2, type, gCHandle.AddrOfPinnedObject(), primcount);
				indices = (T3)gCHandle.Target;
			}
			finally
			{
				gCHandle.Free();
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiDrawElements(BeginMode mode, int* count, DrawElementsType type, IntPtr indices, int primcount)
	{
		Core.MultiDrawElements(mode, count, type, indices, primcount);
	}

	[CLSCompliant(false)]
	public unsafe static void MultiDrawElements<T3>(BeginMode mode, int* count, DrawElementsType type, [In][Out] T3[] indices, int primcount) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.MultiDrawElements(mode, count, type, gCHandle.AddrOfPinnedObject(), primcount);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiDrawElements<T3>(BeginMode mode, int* count, DrawElementsType type, [In][Out] T3[,] indices, int primcount) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.MultiDrawElements(mode, count, type, gCHandle.AddrOfPinnedObject(), primcount);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiDrawElements<T3>(BeginMode mode, int* count, DrawElementsType type, [In][Out] T3[,,] indices, int primcount) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.MultiDrawElements(mode, count, type, gCHandle.AddrOfPinnedObject(), primcount);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiDrawElements<T3>(BeginMode mode, int* count, DrawElementsType type, [In][Out] ref T3 indices, int primcount) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(indices, GCHandleType.Pinned);
		try
		{
			Core.MultiDrawElements(mode, count, type, gCHandle.AddrOfPinnedObject(), primcount);
			indices = (T3)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void MultiTexCoord1(TextureUnit target, double s)
	{
		Core.MultiTexCoord1d(target, s);
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord1(TextureUnit target, double* v)
	{
		Core.MultiTexCoord1dv(target, v);
	}

	public static void MultiTexCoord1(TextureUnit target, float s)
	{
		Core.MultiTexCoord1f(target, s);
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord1(TextureUnit target, float* v)
	{
		Core.MultiTexCoord1fv(target, v);
	}

	public static void MultiTexCoord1(TextureUnit target, int s)
	{
		Core.MultiTexCoord1i(target, s);
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord1(TextureUnit target, int* v)
	{
		Core.MultiTexCoord1iv(target, v);
	}

	public static void MultiTexCoord1(TextureUnit target, short s)
	{
		Core.MultiTexCoord1s(target, s);
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord1(TextureUnit target, short* v)
	{
		Core.MultiTexCoord1sv(target, v);
	}

	public static void MultiTexCoord2(TextureUnit target, double s, double t)
	{
		Core.MultiTexCoord2d(target, s, t);
	}

	public unsafe static void MultiTexCoord2(TextureUnit target, double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.MultiTexCoord2dv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord2(TextureUnit target, ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.MultiTexCoord2dv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord2(TextureUnit target, double* v)
	{
		Core.MultiTexCoord2dv(target, v);
	}

	public static void MultiTexCoord2(TextureUnit target, float s, float t)
	{
		Core.MultiTexCoord2f(target, s, t);
	}

	public unsafe static void MultiTexCoord2(TextureUnit target, float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.MultiTexCoord2fv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord2(TextureUnit target, ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.MultiTexCoord2fv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord2(TextureUnit target, float* v)
	{
		Core.MultiTexCoord2fv(target, v);
	}

	public static void MultiTexCoord2(TextureUnit target, int s, int t)
	{
		Core.MultiTexCoord2i(target, s, t);
	}

	public unsafe static void MultiTexCoord2(TextureUnit target, int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.MultiTexCoord2iv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord2(TextureUnit target, ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.MultiTexCoord2iv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord2(TextureUnit target, int* v)
	{
		Core.MultiTexCoord2iv(target, v);
	}

	public static void MultiTexCoord2(TextureUnit target, short s, short t)
	{
		Core.MultiTexCoord2s(target, s, t);
	}

	public unsafe static void MultiTexCoord2(TextureUnit target, short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.MultiTexCoord2sv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord2(TextureUnit target, ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.MultiTexCoord2sv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord2(TextureUnit target, short* v)
	{
		Core.MultiTexCoord2sv(target, v);
	}

	public static void MultiTexCoord3(TextureUnit target, double s, double t, double r)
	{
		Core.MultiTexCoord3d(target, s, t, r);
	}

	public unsafe static void MultiTexCoord3(TextureUnit target, double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.MultiTexCoord3dv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord3(TextureUnit target, ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.MultiTexCoord3dv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord3(TextureUnit target, double* v)
	{
		Core.MultiTexCoord3dv(target, v);
	}

	public static void MultiTexCoord3(TextureUnit target, float s, float t, float r)
	{
		Core.MultiTexCoord3f(target, s, t, r);
	}

	public unsafe static void MultiTexCoord3(TextureUnit target, float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.MultiTexCoord3fv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord3(TextureUnit target, ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.MultiTexCoord3fv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord3(TextureUnit target, float* v)
	{
		Core.MultiTexCoord3fv(target, v);
	}

	public static void MultiTexCoord3(TextureUnit target, int s, int t, int r)
	{
		Core.MultiTexCoord3i(target, s, t, r);
	}

	public unsafe static void MultiTexCoord3(TextureUnit target, int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.MultiTexCoord3iv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord3(TextureUnit target, ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.MultiTexCoord3iv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord3(TextureUnit target, int* v)
	{
		Core.MultiTexCoord3iv(target, v);
	}

	public static void MultiTexCoord3(TextureUnit target, short s, short t, short r)
	{
		Core.MultiTexCoord3s(target, s, t, r);
	}

	public unsafe static void MultiTexCoord3(TextureUnit target, short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.MultiTexCoord3sv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord3(TextureUnit target, ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.MultiTexCoord3sv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord3(TextureUnit target, short* v)
	{
		Core.MultiTexCoord3sv(target, v);
	}

	public static void MultiTexCoord4(TextureUnit target, double s, double t, double r, double q)
	{
		Core.MultiTexCoord4d(target, s, t, r, q);
	}

	public unsafe static void MultiTexCoord4(TextureUnit target, double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.MultiTexCoord4dv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord4(TextureUnit target, ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.MultiTexCoord4dv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord4(TextureUnit target, double* v)
	{
		Core.MultiTexCoord4dv(target, v);
	}

	public static void MultiTexCoord4(TextureUnit target, float s, float t, float r, float q)
	{
		Core.MultiTexCoord4f(target, s, t, r, q);
	}

	public unsafe static void MultiTexCoord4(TextureUnit target, float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.MultiTexCoord4fv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord4(TextureUnit target, ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.MultiTexCoord4fv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord4(TextureUnit target, float* v)
	{
		Core.MultiTexCoord4fv(target, v);
	}

	public static void MultiTexCoord4(TextureUnit target, int s, int t, int r, int q)
	{
		Core.MultiTexCoord4i(target, s, t, r, q);
	}

	public unsafe static void MultiTexCoord4(TextureUnit target, int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.MultiTexCoord4iv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord4(TextureUnit target, ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.MultiTexCoord4iv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord4(TextureUnit target, int* v)
	{
		Core.MultiTexCoord4iv(target, v);
	}

	public static void MultiTexCoord4(TextureUnit target, short s, short t, short r, short q)
	{
		Core.MultiTexCoord4s(target, s, t, r, q);
	}

	public unsafe static void MultiTexCoord4(TextureUnit target, short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.MultiTexCoord4sv(target, v2);
		}
	}

	public unsafe static void MultiTexCoord4(TextureUnit target, ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.MultiTexCoord4sv(target, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultiTexCoord4(TextureUnit target, short* v)
	{
		Core.MultiTexCoord4sv(target, v);
	}

	public unsafe static void MultMatrix(double[] m)
	{
		fixed (double* m2 = m)
		{
			Core.MultMatrixd(m2);
		}
	}

	public unsafe static void MultMatrix(ref double m)
	{
		fixed (double* m2 = &m)
		{
			Core.MultMatrixd(m2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultMatrix(double* m)
	{
		Core.MultMatrixd(m);
	}

	public unsafe static void MultMatrix(float[] m)
	{
		fixed (float* m2 = m)
		{
			Core.MultMatrixf(m2);
		}
	}

	public unsafe static void MultMatrix(ref float m)
	{
		fixed (float* m2 = &m)
		{
			Core.MultMatrixf(m2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultMatrix(float* m)
	{
		Core.MultMatrixf(m);
	}

	public unsafe static void MultTransposeMatrix(double[] m)
	{
		fixed (double* m2 = m)
		{
			Core.MultTransposeMatrixd(m2);
		}
	}

	public unsafe static void MultTransposeMatrix(ref double m)
	{
		fixed (double* m2 = &m)
		{
			Core.MultTransposeMatrixd(m2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultTransposeMatrix(double* m)
	{
		Core.MultTransposeMatrixd(m);
	}

	public unsafe static void MultTransposeMatrix(float[] m)
	{
		fixed (float* m2 = m)
		{
			Core.MultTransposeMatrixf(m2);
		}
	}

	public unsafe static void MultTransposeMatrix(ref float m)
	{
		fixed (float* m2 = &m)
		{
			Core.MultTransposeMatrixf(m2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void MultTransposeMatrix(float* m)
	{
		Core.MultTransposeMatrixf(m);
	}

	public static void NewList(int list, ListMode mode)
	{
		Core.NewList((uint)list, mode);
	}

	[CLSCompliant(false)]
	public static void NewList(uint list, ListMode mode)
	{
		Core.NewList(list, mode);
	}

	public static void Normal3(byte nx, byte ny, byte nz)
	{
		Core.Normal3b((sbyte)nx, (sbyte)ny, (sbyte)nz);
	}

	[CLSCompliant(false)]
	public static void Normal3(sbyte nx, sbyte ny, sbyte nz)
	{
		Core.Normal3b(nx, ny, nz);
	}

	public unsafe static void Normal3(byte[] v)
	{
		fixed (byte* v2 = v)
		{
			Core.Normal3bv((sbyte*)v2);
		}
	}

	public unsafe static void Normal3(ref byte v)
	{
		fixed (byte* v2 = &v)
		{
			Core.Normal3bv((sbyte*)v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Normal3(byte* v)
	{
		Core.Normal3bv((sbyte*)v);
	}

	[CLSCompliant(false)]
	public unsafe static void Normal3(sbyte[] v)
	{
		fixed (sbyte* v2 = v)
		{
			Core.Normal3bv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Normal3(ref sbyte v)
	{
		fixed (sbyte* v2 = &v)
		{
			Core.Normal3bv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Normal3(sbyte* v)
	{
		Core.Normal3bv(v);
	}

	public static void Normal3(double nx, double ny, double nz)
	{
		Core.Normal3d(nx, ny, nz);
	}

	public unsafe static void Normal3(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.Normal3dv(v2);
		}
	}

	public unsafe static void Normal3(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.Normal3dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Normal3(double* v)
	{
		Core.Normal3dv(v);
	}

	public static void Normal3(float nx, float ny, float nz)
	{
		Core.Normal3f(nx, ny, nz);
	}

	public unsafe static void Normal3(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.Normal3fv(v2);
		}
	}

	public unsafe static void Normal3(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.Normal3fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Normal3(float* v)
	{
		Core.Normal3fv(v);
	}

	public static void Normal3(int nx, int ny, int nz)
	{
		Core.Normal3i(nx, ny, nz);
	}

	public unsafe static void Normal3(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.Normal3iv(v2);
		}
	}

	public unsafe static void Normal3(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.Normal3iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Normal3(int* v)
	{
		Core.Normal3iv(v);
	}

	public static void Normal3(short nx, short ny, short nz)
	{
		Core.Normal3s(nx, ny, nz);
	}

	public unsafe static void Normal3(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.Normal3sv(v2);
		}
	}

	public unsafe static void Normal3(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.Normal3sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Normal3(short* v)
	{
		Core.Normal3sv(v);
	}

	public static void NormalPointer(NormalPointerType type, int stride, IntPtr pointer)
	{
		Core.NormalPointer(type, stride, pointer);
	}

	public static void NormalPointer<T2>(NormalPointerType type, int stride, [In][Out] T2[] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.NormalPointer(type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void NormalPointer<T2>(NormalPointerType type, int stride, [In][Out] T2[,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.NormalPointer(type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void NormalPointer<T2>(NormalPointerType type, int stride, [In][Out] T2[,,] pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.NormalPointer(type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void NormalPointer<T2>(NormalPointerType type, int stride, [In][Out] ref T2 pointer) where T2 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.NormalPointer(type, stride, gCHandle.AddrOfPinnedObject());
			pointer = (T2)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar)
	{
		Core.Ortho(left, right, bottom, top, zNear, zFar);
	}

	public static void PassThrough(float token)
	{
		Core.PassThrough(token);
	}

	public unsafe static void PixelMap(PixelMap map, int mapsize, float[] values)
	{
		fixed (float* values2 = values)
		{
			Core.PixelMapfv(map, mapsize, values2);
		}
	}

	public unsafe static void PixelMap(PixelMap map, int mapsize, ref float values)
	{
		fixed (float* values2 = &values)
		{
			Core.PixelMapfv(map, mapsize, values2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PixelMap(PixelMap map, int mapsize, float* values)
	{
		Core.PixelMapfv(map, mapsize, values);
	}

	public unsafe static void PixelMap(PixelMap map, int mapsize, int[] values)
	{
		fixed (int* values2 = values)
		{
			Core.PixelMapuiv(map, mapsize, (uint*)values2);
		}
	}

	public unsafe static void PixelMap(PixelMap map, int mapsize, ref int values)
	{
		fixed (int* values2 = &values)
		{
			Core.PixelMapuiv(map, mapsize, (uint*)values2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PixelMap(PixelMap map, int mapsize, int* values)
	{
		Core.PixelMapuiv(map, mapsize, (uint*)values);
	}

	[CLSCompliant(false)]
	public unsafe static void PixelMap(PixelMap map, int mapsize, uint[] values)
	{
		fixed (uint* values2 = values)
		{
			Core.PixelMapuiv(map, mapsize, values2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PixelMap(PixelMap map, int mapsize, ref uint values)
	{
		fixed (uint* values2 = &values)
		{
			Core.PixelMapuiv(map, mapsize, values2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PixelMap(PixelMap map, int mapsize, uint* values)
	{
		Core.PixelMapuiv(map, mapsize, values);
	}

	public unsafe static void PixelMap(PixelMap map, int mapsize, short[] values)
	{
		fixed (short* values2 = values)
		{
			Core.PixelMapusv(map, mapsize, (ushort*)values2);
		}
	}

	public unsafe static void PixelMap(PixelMap map, int mapsize, ref short values)
	{
		fixed (short* values2 = &values)
		{
			Core.PixelMapusv(map, mapsize, (ushort*)values2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PixelMap(PixelMap map, int mapsize, short* values)
	{
		Core.PixelMapusv(map, mapsize, (ushort*)values);
	}

	[CLSCompliant(false)]
	public unsafe static void PixelMap(PixelMap map, int mapsize, ushort[] values)
	{
		fixed (ushort* values2 = values)
		{
			Core.PixelMapusv(map, mapsize, values2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PixelMap(PixelMap map, int mapsize, ref ushort values)
	{
		fixed (ushort* values2 = &values)
		{
			Core.PixelMapusv(map, mapsize, values2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PixelMap(PixelMap map, int mapsize, ushort* values)
	{
		Core.PixelMapusv(map, mapsize, values);
	}

	public static void PixelStore(PixelStoreParameter pname, float param)
	{
		Core.PixelStoref(pname, param);
	}

	public static void PixelStore(PixelStoreParameter pname, int param)
	{
		Core.PixelStorei(pname, param);
	}

	public static void PixelTransfer(PixelTransferParameter pname, float param)
	{
		Core.PixelTransferf(pname, param);
	}

	public static void PixelTransfer(PixelTransferParameter pname, int param)
	{
		Core.PixelTransferi(pname, param);
	}

	public static void PixelZoom(float xfactor, float yfactor)
	{
		Core.PixelZoom(xfactor, yfactor);
	}

	public static void PointParameter(PointParameterName pname, float param)
	{
		Core.PointParameterf(pname, param);
	}

	public unsafe static void PointParameter(PointParameterName pname, float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.PointParameterfv(pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PointParameter(PointParameterName pname, float* @params)
	{
		Core.PointParameterfv(pname, @params);
	}

	public static void PointParameter(PointParameterName pname, int param)
	{
		Core.PointParameteri(pname, param);
	}

	public unsafe static void PointParameter(PointParameterName pname, int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.PointParameteriv(pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PointParameter(PointParameterName pname, int* @params)
	{
		Core.PointParameteriv(pname, @params);
	}

	public static void PointSize(float size)
	{
		Core.PointSize(size);
	}

	public static void PolygonMode(MaterialFace face, PolygonMode mode)
	{
		Core.PolygonMode(face, mode);
	}

	public static void PolygonOffset(float factor, float units)
	{
		Core.PolygonOffset(factor, units);
	}

	public unsafe static void PolygonStipple(byte[] mask)
	{
		fixed (byte* mask2 = mask)
		{
			Core.PolygonStipple(mask2);
		}
	}

	public unsafe static void PolygonStipple(ref byte mask)
	{
		fixed (byte* mask2 = &mask)
		{
			Core.PolygonStipple(mask2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PolygonStipple(byte* mask)
	{
		Core.PolygonStipple(mask);
	}

	public static void PopAttrib()
	{
		Core.PopAttrib();
	}

	public static void PopClientAttrib()
	{
		Core.PopClientAttrib();
	}

	public static void PopMatrix()
	{
		Core.PopMatrix();
	}

	public static void PopName()
	{
		Core.PopName();
	}

	public unsafe static void PrioritizeTextures(int n, int[] textures, float[] priorities)
	{
		fixed (int* textures2 = textures)
		{
			fixed (float* priorities2 = priorities)
			{
				Core.PrioritizeTextures(n, (uint*)textures2, priorities2);
			}
		}
	}

	public unsafe static void PrioritizeTextures(int n, ref int textures, ref float priorities)
	{
		fixed (int* textures2 = &textures)
		{
			fixed (float* priorities2 = &priorities)
			{
				Core.PrioritizeTextures(n, (uint*)textures2, priorities2);
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PrioritizeTextures(int n, int* textures, float* priorities)
	{
		Core.PrioritizeTextures(n, (uint*)textures, priorities);
	}

	[CLSCompliant(false)]
	public unsafe static void PrioritizeTextures(int n, uint[] textures, float[] priorities)
	{
		fixed (uint* textures2 = textures)
		{
			fixed (float* priorities2 = priorities)
			{
				Core.PrioritizeTextures(n, textures2, priorities2);
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PrioritizeTextures(int n, ref uint textures, ref float priorities)
	{
		fixed (uint* textures2 = &textures)
		{
			fixed (float* priorities2 = &priorities)
			{
				Core.PrioritizeTextures(n, textures2, priorities2);
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void PrioritizeTextures(int n, uint* textures, float* priorities)
	{
		Core.PrioritizeTextures(n, textures, priorities);
	}

	public unsafe static void ProgramUniformMatrix2x3(int program, int location, int count, bool transpose, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.ProgramUniformMatrix2x3fv((uint)program, location, count, transpose, value2);
		}
	}

	public unsafe static void ProgramUniformMatrix2x3(int program, int location, int count, bool transpose, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.ProgramUniformMatrix2x3fv((uint)program, location, count, transpose, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void ProgramUniformMatrix2x3(int program, int location, int count, bool transpose, float* value)
	{
		Core.ProgramUniformMatrix2x3fv((uint)program, location, count, transpose, value);
	}

	[CLSCompliant(false)]
	public unsafe static void ProgramUniformMatrix2x3(uint program, int location, int count, bool transpose, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.ProgramUniformMatrix2x3fv(program, location, count, transpose, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void ProgramUniformMatrix2x3(uint program, int location, int count, bool transpose, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.ProgramUniformMatrix2x3fv(program, location, count, transpose, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void ProgramUniformMatrix2x3(uint program, int location, int count, bool transpose, float* value)
	{
		Core.ProgramUniformMatrix2x3fv(program, location, count, transpose, value);
	}

	public static void PushAttrib(AttribMask mask)
	{
		Core.PushAttrib(mask);
	}

	public static void PushClientAttrib(ClientAttribMask mask)
	{
		Core.PushClientAttrib(mask);
	}

	public static void PushMatrix()
	{
		Core.PushMatrix();
	}

	public static void PushName(int name)
	{
		Core.PushName((uint)name);
	}

	[CLSCompliant(false)]
	public static void PushName(uint name)
	{
		Core.PushName(name);
	}

	public static void RasterPos2(double x, double y)
	{
		Core.RasterPos2d(x, y);
	}

	public unsafe static void RasterPos2(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.RasterPos2dv(v2);
		}
	}

	public unsafe static void RasterPos2(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.RasterPos2dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos2(double* v)
	{
		Core.RasterPos2dv(v);
	}

	public static void RasterPos2(float x, float y)
	{
		Core.RasterPos2f(x, y);
	}

	public unsafe static void RasterPos2(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.RasterPos2fv(v2);
		}
	}

	public unsafe static void RasterPos2(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.RasterPos2fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos2(float* v)
	{
		Core.RasterPos2fv(v);
	}

	public static void RasterPos2(int x, int y)
	{
		Core.RasterPos2i(x, y);
	}

	public unsafe static void RasterPos2(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.RasterPos2iv(v2);
		}
	}

	public unsafe static void RasterPos2(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.RasterPos2iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos2(int* v)
	{
		Core.RasterPos2iv(v);
	}

	public static void RasterPos2(short x, short y)
	{
		Core.RasterPos2s(x, y);
	}

	public unsafe static void RasterPos2(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.RasterPos2sv(v2);
		}
	}

	public unsafe static void RasterPos2(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.RasterPos2sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos2(short* v)
	{
		Core.RasterPos2sv(v);
	}

	public static void RasterPos3(double x, double y, double z)
	{
		Core.RasterPos3d(x, y, z);
	}

	public unsafe static void RasterPos3(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.RasterPos3dv(v2);
		}
	}

	public unsafe static void RasterPos3(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.RasterPos3dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos3(double* v)
	{
		Core.RasterPos3dv(v);
	}

	public static void RasterPos3(float x, float y, float z)
	{
		Core.RasterPos3f(x, y, z);
	}

	public unsafe static void RasterPos3(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.RasterPos3fv(v2);
		}
	}

	public unsafe static void RasterPos3(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.RasterPos3fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos3(float* v)
	{
		Core.RasterPos3fv(v);
	}

	public static void RasterPos3(int x, int y, int z)
	{
		Core.RasterPos3i(x, y, z);
	}

	public unsafe static void RasterPos3(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.RasterPos3iv(v2);
		}
	}

	public unsafe static void RasterPos3(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.RasterPos3iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos3(int* v)
	{
		Core.RasterPos3iv(v);
	}

	public static void RasterPos3(short x, short y, short z)
	{
		Core.RasterPos3s(x, y, z);
	}

	public unsafe static void RasterPos3(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.RasterPos3sv(v2);
		}
	}

	public unsafe static void RasterPos3(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.RasterPos3sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos3(short* v)
	{
		Core.RasterPos3sv(v);
	}

	public static void RasterPos4(double x, double y, double z, double w)
	{
		Core.RasterPos4d(x, y, z, w);
	}

	public unsafe static void RasterPos4(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.RasterPos4dv(v2);
		}
	}

	public unsafe static void RasterPos4(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.RasterPos4dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos4(double* v)
	{
		Core.RasterPos4dv(v);
	}

	public static void RasterPos4(float x, float y, float z, float w)
	{
		Core.RasterPos4f(x, y, z, w);
	}

	public unsafe static void RasterPos4(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.RasterPos4fv(v2);
		}
	}

	public unsafe static void RasterPos4(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.RasterPos4fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos4(float* v)
	{
		Core.RasterPos4fv(v);
	}

	public static void RasterPos4(int x, int y, int z, int w)
	{
		Core.RasterPos4i(x, y, z, w);
	}

	public unsafe static void RasterPos4(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.RasterPos4iv(v2);
		}
	}

	public unsafe static void RasterPos4(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.RasterPos4iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos4(int* v)
	{
		Core.RasterPos4iv(v);
	}

	public static void RasterPos4(short x, short y, short z, short w)
	{
		Core.RasterPos4s(x, y, z, w);
	}

	public unsafe static void RasterPos4(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.RasterPos4sv(v2);
		}
	}

	public unsafe static void RasterPos4(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.RasterPos4sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void RasterPos4(short* v)
	{
		Core.RasterPos4sv(v);
	}

	public static void ReadBuffer(ReadBufferMode mode)
	{
		Core.ReadBuffer(mode);
	}

	public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, [Out] IntPtr pixels)
	{
		Core.ReadPixels(x, y, width, height, format, type, pixels);
	}

	public static void ReadPixels<T6>(int x, int y, int width, int height, PixelFormat format, PixelType type, [In][Out] T6[] pixels) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.ReadPixels(x, y, width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ReadPixels<T6>(int x, int y, int width, int height, PixelFormat format, PixelType type, [In][Out] T6[,] pixels) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.ReadPixels(x, y, width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ReadPixels<T6>(int x, int y, int width, int height, PixelFormat format, PixelType type, [In][Out] T6[,,] pixels) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.ReadPixels(x, y, width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void ReadPixels<T6>(int x, int y, int width, int height, PixelFormat format, PixelType type, [In][Out] ref T6 pixels) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.ReadPixels(x, y, width, height, format, type, gCHandle.AddrOfPinnedObject());
			pixels = (T6)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void Rect(double x1, double y1, double x2, double y2)
	{
		Core.Rectd(x1, y1, x2, y2);
	}

	public unsafe static void Rect(double[] v1, double[] v2)
	{
		fixed (double* v3 = v1)
		{
			fixed (double* v4 = v2)
			{
				Core.Rectdv(v3, v4);
			}
		}
	}

	public unsafe static void Rect(ref double v1, ref double v2)
	{
		fixed (double* v3 = &v1)
		{
			fixed (double* v4 = &v2)
			{
				Core.Rectdv(v3, v4);
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Rect(double* v1, double* v2)
	{
		Core.Rectdv(v1, v2);
	}

	public static void Rect(float x1, float y1, float x2, float y2)
	{
		Core.Rectf(x1, y1, x2, y2);
	}

	public unsafe static void Rect(float[] v1, float[] v2)
	{
		fixed (float* v3 = v1)
		{
			fixed (float* v4 = v2)
			{
				Core.Rectfv(v3, v4);
			}
		}
	}

	public unsafe static void Rect(ref float v1, ref float v2)
	{
		fixed (float* v3 = &v1)
		{
			fixed (float* v4 = &v2)
			{
				Core.Rectfv(v3, v4);
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Rect(float* v1, float* v2)
	{
		Core.Rectfv(v1, v2);
	}

	public static void Rect(int x1, int y1, int x2, int y2)
	{
		Core.Recti(x1, y1, x2, y2);
	}

	public unsafe static void Rect(int[] v1, int[] v2)
	{
		fixed (int* v3 = v1)
		{
			fixed (int* v4 = v2)
			{
				Core.Rectiv(v3, v4);
			}
		}
	}

	public unsafe static void Rect(ref int v1, ref int v2)
	{
		fixed (int* v3 = &v1)
		{
			fixed (int* v4 = &v2)
			{
				Core.Rectiv(v3, v4);
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Rect(int* v1, int* v2)
	{
		Core.Rectiv(v1, v2);
	}

	public static void Rects(short x1, short y1, short x2, short y2)
	{
		Core.Rects(x1, y1, x2, y2);
	}

	public unsafe static void Rect(short[] v1, short[] v2)
	{
		fixed (short* v3 = v1)
		{
			fixed (short* v4 = v2)
			{
				Core.Rectsv(v3, v4);
			}
		}
	}

	public unsafe static void Rect(ref short v1, ref short v2)
	{
		fixed (short* v3 = &v1)
		{
			fixed (short* v4 = &v2)
			{
				Core.Rectsv(v3, v4);
			}
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Rect(short* v1, short* v2)
	{
		Core.Rectsv(v1, v2);
	}

	public static int RenderMode(RenderingMode mode)
	{
		return Core.RenderMode(mode);
	}

	public static void ResetHistogram(HistogramTarget target)
	{
		Core.ResetHistogram(target);
	}

	public static void ResetMinmax(MinmaxTarget target)
	{
		Core.ResetMinmax(target);
	}

	public static void Rotate(double angle, double x, double y, double z)
	{
		Core.Rotated(angle, x, y, z);
	}

	public static void Rotate(float angle, float x, float y, float z)
	{
		Core.Rotatef(angle, x, y, z);
	}

	public static void Scale(double x, double y, double z)
	{
		Core.Scaled(x, y, z);
	}

	public static void Scale(float x, float y, float z)
	{
		Core.Scalef(x, y, z);
	}

	public static void Scissor(int x, int y, int width, int height)
	{
		Core.Scissor(x, y, width, height);
	}

	[CLSCompliant(false)]
	public static void SecondaryColor3(sbyte red, sbyte green, sbyte blue)
	{
		Core.SecondaryColor3b(red, green, blue);
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(sbyte[] v)
	{
		fixed (sbyte* v2 = v)
		{
			Core.SecondaryColor3bv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(ref sbyte v)
	{
		fixed (sbyte* v2 = &v)
		{
			Core.SecondaryColor3bv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(sbyte* v)
	{
		Core.SecondaryColor3bv(v);
	}

	public static void SecondaryColor3(double red, double green, double blue)
	{
		Core.SecondaryColor3d(red, green, blue);
	}

	public unsafe static void SecondaryColor3(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.SecondaryColor3dv(v2);
		}
	}

	public unsafe static void SecondaryColor3(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.SecondaryColor3dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(double* v)
	{
		Core.SecondaryColor3dv(v);
	}

	public static void SecondaryColor3(float red, float green, float blue)
	{
		Core.SecondaryColor3f(red, green, blue);
	}

	public unsafe static void SecondaryColor3(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.SecondaryColor3fv(v2);
		}
	}

	public unsafe static void SecondaryColor3(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.SecondaryColor3fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(float* v)
	{
		Core.SecondaryColor3fv(v);
	}

	public static void SecondaryColor3(int red, int green, int blue)
	{
		Core.SecondaryColor3i(red, green, blue);
	}

	public unsafe static void SecondaryColor3(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.SecondaryColor3iv(v2);
		}
	}

	public unsafe static void SecondaryColor3(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.SecondaryColor3iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(int* v)
	{
		Core.SecondaryColor3iv(v);
	}

	public static void SecondaryColor3(short red, short green, short blue)
	{
		Core.SecondaryColor3s(red, green, blue);
	}

	public unsafe static void SecondaryColor3(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.SecondaryColor3sv(v2);
		}
	}

	public unsafe static void SecondaryColor3(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.SecondaryColor3sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(short* v)
	{
		Core.SecondaryColor3sv(v);
	}

	public static void SecondaryColor3(byte red, byte green, byte blue)
	{
		Core.SecondaryColor3ub(red, green, blue);
	}

	public unsafe static void SecondaryColor3(byte[] v)
	{
		fixed (byte* v2 = v)
		{
			Core.SecondaryColor3ubv(v2);
		}
	}

	public unsafe static void SecondaryColor3(ref byte v)
	{
		fixed (byte* v2 = &v)
		{
			Core.SecondaryColor3ubv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(byte* v)
	{
		Core.SecondaryColor3ubv(v);
	}

	[CLSCompliant(false)]
	public static void SecondaryColor3(uint red, uint green, uint blue)
	{
		Core.SecondaryColor3ui(red, green, blue);
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(uint[] v)
	{
		fixed (uint* v2 = v)
		{
			Core.SecondaryColor3uiv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(ref uint v)
	{
		fixed (uint* v2 = &v)
		{
			Core.SecondaryColor3uiv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(uint* v)
	{
		Core.SecondaryColor3uiv(v);
	}

	[CLSCompliant(false)]
	public static void SecondaryColor3(ushort red, ushort green, ushort blue)
	{
		Core.SecondaryColor3us(red, green, blue);
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(ushort[] v)
	{
		fixed (ushort* v2 = v)
		{
			Core.SecondaryColor3usv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(ref ushort v)
	{
		fixed (ushort* v2 = &v)
		{
			Core.SecondaryColor3usv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SecondaryColor3(ushort* v)
	{
		Core.SecondaryColor3usv(v);
	}

	public static void SecondaryColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer)
	{
		Core.SecondaryColorPointer(size, type, stride, pointer);
	}

	public static void SecondaryColorPointer<T3>(int size, ColorPointerType type, int stride, [In][Out] T3[] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.SecondaryColorPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void SecondaryColorPointer<T3>(int size, ColorPointerType type, int stride, [In][Out] T3[,] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.SecondaryColorPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void SecondaryColorPointer<T3>(int size, ColorPointerType type, int stride, [In][Out] T3[,,] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.SecondaryColorPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void SecondaryColorPointer<T3>(int size, ColorPointerType type, int stride, [In][Out] ref T3 pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.SecondaryColorPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
			pointer = (T3)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public unsafe static void SelectBuffer(int size, [Out] int[] buffer)
	{
		fixed (int* buffer2 = buffer)
		{
			Core.SelectBuffer(size, (uint*)buffer2);
		}
	}

	public unsafe static void SelectBuffer(int size, out int buffer)
	{
		fixed (int* ptr = &buffer)
		{
			Core.SelectBuffer(size, (uint*)ptr);
			buffer = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SelectBuffer(int size, [Out] int* buffer)
	{
		Core.SelectBuffer(size, (uint*)buffer);
	}

	[CLSCompliant(false)]
	public unsafe static void SelectBuffer(int size, [Out] uint[] buffer)
	{
		fixed (uint* buffer2 = buffer)
		{
			Core.SelectBuffer(size, buffer2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SelectBuffer(int size, out uint buffer)
	{
		fixed (uint* ptr = &buffer)
		{
			Core.SelectBuffer(size, ptr);
			buffer = *ptr;
		}
	}

	[CLSCompliant(false)]
	public unsafe static void SelectBuffer(int size, [Out] uint* buffer)
	{
		Core.SelectBuffer(size, buffer);
	}

	public static void SeparableFilter2D(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr row, IntPtr column)
	{
		Core.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
	}

	public static void SeparableFilter2D<T7>(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr row, [In][Out] T7[] column) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(column, GCHandleType.Pinned);
		try
		{
			Core.SeparableFilter2D(target, internalformat, width, height, format, type, row, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void SeparableFilter2D<T7>(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr row, [In][Out] T7[,] column) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(column, GCHandleType.Pinned);
		try
		{
			Core.SeparableFilter2D(target, internalformat, width, height, format, type, row, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void SeparableFilter2D<T7>(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr row, [In][Out] T7[,,] column) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(column, GCHandleType.Pinned);
		try
		{
			Core.SeparableFilter2D(target, internalformat, width, height, format, type, row, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void SeparableFilter2D<T7>(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, IntPtr row, [In][Out] ref T7 column) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(column, GCHandleType.Pinned);
		try
		{
			Core.SeparableFilter2D(target, internalformat, width, height, format, type, row, gCHandle.AddrOfPinnedObject());
			column = (T7)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void SeparableFilter2D<T6, T7>(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, [In][Out] T6[] row, [In][Out] T7[,,] column) where T6 : struct where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(row, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(column, GCHandleType.Pinned);
		try
		{
			Core.SeparableFilter2D(target, internalformat, width, height, format, type, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
		}
	}

	public static void SeparableFilter2D<T6, T7>(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, [In][Out] T6[,] row, [In][Out] T7[,,] column) where T6 : struct where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(row, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(column, GCHandleType.Pinned);
		try
		{
			Core.SeparableFilter2D(target, internalformat, width, height, format, type, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
		}
	}

	public static void SeparableFilter2D<T6, T7>(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, [In][Out] T6[,,] row, [In][Out] T7[,,] column) where T6 : struct where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(row, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(column, GCHandleType.Pinned);
		try
		{
			Core.SeparableFilter2D(target, internalformat, width, height, format, type, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
		}
	}

	public static void SeparableFilter2D<T6, T7>(SeparableTarget target, PixelInternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, [In][Out] ref T6 row, [In][Out] T7[,,] column) where T6 : struct where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(row, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(column, GCHandleType.Pinned);
		try
		{
			Core.SeparableFilter2D(target, internalformat, width, height, format, type, gCHandle.AddrOfPinnedObject(), gCHandle2.AddrOfPinnedObject());
			row = (T6)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
		}
	}

	public static void ShadeModel(ShadingModel mode)
	{
		Core.ShadeModel(mode);
	}

	public unsafe static void ShaderSource(int shader, int count, string[] @string, ref int length)
	{
		fixed (int* length2 = &length)
		{
			Core.ShaderSource((uint)shader, count, @string, length2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void ShaderSource(int shader, int count, string[] @string, int* length)
	{
		Core.ShaderSource((uint)shader, count, @string, length);
	}

	[CLSCompliant(false)]
	public unsafe static void ShaderSource(uint shader, int count, string[] @string, ref int length)
	{
		fixed (int* length2 = &length)
		{
			Core.ShaderSource(shader, count, @string, length2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void ShaderSource(uint shader, int count, string[] @string, int* length)
	{
		Core.ShaderSource(shader, count, @string, length);
	}

	public static void StencilFunc(StencilFunction func, int @ref, int mask)
	{
		Core.StencilFunc(func, @ref, (uint)mask);
	}

	[CLSCompliant(false)]
	public static void StencilFunc(StencilFunction func, int @ref, uint mask)
	{
		Core.StencilFunc(func, @ref, mask);
	}

	public static void StencilFuncSeparate(Version20 face, StencilFunction func, int @ref, int mask)
	{
		Core.StencilFuncSeparate(face, func, @ref, (uint)mask);
	}

	[CLSCompliant(false)]
	public static void StencilFuncSeparate(Version20 face, StencilFunction func, int @ref, uint mask)
	{
		Core.StencilFuncSeparate(face, func, @ref, mask);
	}

	public static void StencilMask(int mask)
	{
		Core.StencilMask((uint)mask);
	}

	[CLSCompliant(false)]
	public static void StencilMask(uint mask)
	{
		Core.StencilMask(mask);
	}

	public static void StencilMaskSeparate(StencilFace face, int mask)
	{
		Core.StencilMaskSeparate(face, (uint)mask);
	}

	[CLSCompliant(false)]
	public static void StencilMaskSeparate(StencilFace face, uint mask)
	{
		Core.StencilMaskSeparate(face, mask);
	}

	public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
	{
		Core.StencilOp(fail, zfail, zpass);
	}

	public static void StencilOpSeparate(StencilFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
	{
		Core.StencilOpSeparate(face, sfail, dpfail, dppass);
	}

	public static void TexCoord1(double s)
	{
		Core.TexCoord1d(s);
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord1(double* v)
	{
		Core.TexCoord1dv(v);
	}

	public static void TexCoord1(float s)
	{
		Core.TexCoord1f(s);
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord1(float* v)
	{
		Core.TexCoord1fv(v);
	}

	public static void TexCoord1(int s)
	{
		Core.TexCoord1i(s);
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord1(int* v)
	{
		Core.TexCoord1iv(v);
	}

	public static void TexCoord1(short s)
	{
		Core.TexCoord1s(s);
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord1(short* v)
	{
		Core.TexCoord1sv(v);
	}

	public static void TexCoord2(double s, double t)
	{
		Core.TexCoord2d(s, t);
	}

	public unsafe static void TexCoord2(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.TexCoord2dv(v2);
		}
	}

	public unsafe static void TexCoord2(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.TexCoord2dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord2(double* v)
	{
		Core.TexCoord2dv(v);
	}

	public static void TexCoord2(float s, float t)
	{
		Core.TexCoord2f(s, t);
	}

	public unsafe static void TexCoord2(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.TexCoord2fv(v2);
		}
	}

	public unsafe static void TexCoord2(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.TexCoord2fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord2(float* v)
	{
		Core.TexCoord2fv(v);
	}

	public static void TexCoord2(int s, int t)
	{
		Core.TexCoord2i(s, t);
	}

	public unsafe static void TexCoord2(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.TexCoord2iv(v2);
		}
	}

	public unsafe static void TexCoord2(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.TexCoord2iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord2(int* v)
	{
		Core.TexCoord2iv(v);
	}

	public static void TexCoord2(short s, short t)
	{
		Core.TexCoord2s(s, t);
	}

	public unsafe static void TexCoord2(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.TexCoord2sv(v2);
		}
	}

	public unsafe static void TexCoord2(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.TexCoord2sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord2(short* v)
	{
		Core.TexCoord2sv(v);
	}

	public static void TexCoord3(double s, double t, double r)
	{
		Core.TexCoord3d(s, t, r);
	}

	public unsafe static void TexCoord3(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.TexCoord3dv(v2);
		}
	}

	public unsafe static void TexCoord3(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.TexCoord3dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord3(double* v)
	{
		Core.TexCoord3dv(v);
	}

	public static void TexCoord3(float s, float t, float r)
	{
		Core.TexCoord3f(s, t, r);
	}

	public unsafe static void TexCoord3(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.TexCoord3fv(v2);
		}
	}

	public unsafe static void TexCoord3(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.TexCoord3fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord3(float* v)
	{
		Core.TexCoord3fv(v);
	}

	public static void TexCoord3(int s, int t, int r)
	{
		Core.TexCoord3i(s, t, r);
	}

	public unsafe static void TexCoord3(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.TexCoord3iv(v2);
		}
	}

	public unsafe static void TexCoord3(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.TexCoord3iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord3(int* v)
	{
		Core.TexCoord3iv(v);
	}

	public static void TexCoord3(short s, short t, short r)
	{
		Core.TexCoord3s(s, t, r);
	}

	public unsafe static void TexCoord3(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.TexCoord3sv(v2);
		}
	}

	public unsafe static void TexCoord3(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.TexCoord3sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord3(short* v)
	{
		Core.TexCoord3sv(v);
	}

	public static void TexCoord4(double s, double t, double r, double q)
	{
		Core.TexCoord4d(s, t, r, q);
	}

	public unsafe static void TexCoord4(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.TexCoord4dv(v2);
		}
	}

	public unsafe static void TexCoord4(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.TexCoord4dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord4(double* v)
	{
		Core.TexCoord4dv(v);
	}

	public static void TexCoord4(float s, float t, float r, float q)
	{
		Core.TexCoord4f(s, t, r, q);
	}

	public unsafe static void TexCoord4(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.TexCoord4fv(v2);
		}
	}

	public unsafe static void TexCoord4(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.TexCoord4fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord4(float* v)
	{
		Core.TexCoord4fv(v);
	}

	public static void TexCoord4(int s, int t, int r, int q)
	{
		Core.TexCoord4i(s, t, r, q);
	}

	public unsafe static void TexCoord4(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.TexCoord4iv(v2);
		}
	}

	public unsafe static void TexCoord4(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.TexCoord4iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord4(int* v)
	{
		Core.TexCoord4iv(v);
	}

	public static void TexCoord4(short s, short t, short r, short q)
	{
		Core.TexCoord4s(s, t, r, q);
	}

	public unsafe static void TexCoord4(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.TexCoord4sv(v2);
		}
	}

	public unsafe static void TexCoord4(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.TexCoord4sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexCoord4(short* v)
	{
		Core.TexCoord4sv(v);
	}

	public static void TexCoordPointer(int size, TexCoordPointerType type, int stride, IntPtr pointer)
	{
		Core.TexCoordPointer(size, type, stride, pointer);
	}

	public static void TexCoordPointer<T3>(int size, TexCoordPointerType type, int stride, [In][Out] T3[] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.TexCoordPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexCoordPointer<T3>(int size, TexCoordPointerType type, int stride, [In][Out] T3[,] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.TexCoordPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexCoordPointer<T3>(int size, TexCoordPointerType type, int stride, [In][Out] T3[,,] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.TexCoordPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexCoordPointer<T3>(int size, TexCoordPointerType type, int stride, [In][Out] ref T3 pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.TexCoordPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
			pointer = (T3)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float param)
	{
		Core.TexEnvf(target, pname, param);
	}

	public unsafe static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.TexEnvfv(target, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float* @params)
	{
		Core.TexEnvfv(target, pname, @params);
	}

	public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, int param)
	{
		Core.TexEnvi(target, pname, param);
	}

	public unsafe static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.TexEnviv(target, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, int* @params)
	{
		Core.TexEnviv(target, pname, @params);
	}

	public static void TexGend(TextureCoordName coord, TextureGenParameter pname, double param)
	{
		Core.TexGend(coord, pname, param);
	}

	public unsafe static void TexGen(TextureCoordName coord, TextureGenParameter pname, double[] @params)
	{
		fixed (double* params2 = @params)
		{
			Core.TexGendv(coord, pname, params2);
		}
	}

	public unsafe static void TexGen(TextureCoordName coord, TextureGenParameter pname, ref double @params)
	{
		fixed (double* params2 = &@params)
		{
			Core.TexGendv(coord, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexGen(TextureCoordName coord, TextureGenParameter pname, double* @params)
	{
		Core.TexGendv(coord, pname, @params);
	}

	public static void TexGen(TextureCoordName coord, TextureGenParameter pname, float param)
	{
		Core.TexGenf(coord, pname, param);
	}

	public unsafe static void TexGen(TextureCoordName coord, TextureGenParameter pname, float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.TexGenfv(coord, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexGen(TextureCoordName coord, TextureGenParameter pname, float* @params)
	{
		Core.TexGenfv(coord, pname, @params);
	}

	public static void TexGen(TextureCoordName coord, TextureGenParameter pname, int param)
	{
		Core.TexGeni(coord, pname, param);
	}

	public unsafe static void TexGen(TextureCoordName coord, TextureGenParameter pname, int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.TexGeniv(coord, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexGen(TextureCoordName coord, TextureGenParameter pname, int* @params)
	{
		Core.TexGeniv(coord, pname, @params);
	}

	public static void TexImage1D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, IntPtr pixels)
	{
		Core.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
	}

	public static void TexImage1D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, [In][Out] T7[] pixels) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage1D(target, level, internalformat, width, border, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexImage1D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, [In][Out] T7[,] pixels) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage1D(target, level, internalformat, width, border, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexImage1D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, [In][Out] T7[,,] pixels) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage1D(target, level, internalformat, width, border, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexImage1D<T7>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, [In][Out] ref T7 pixels) where T7 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage1D(target, level, internalformat, width, border, format, type, gCHandle.AddrOfPinnedObject());
			pixels = (T7)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
	{
		Core.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
	}

	public static void TexImage2D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, [In][Out] T8[] pixels) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage2D(target, level, internalformat, width, height, border, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexImage2D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, [In][Out] T8[,] pixels) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage2D(target, level, internalformat, width, height, border, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexImage2D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, [In][Out] T8[,,] pixels) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage2D(target, level, internalformat, width, height, border, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexImage2D<T8>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, [In][Out] ref T8 pixels) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage2D(target, level, internalformat, width, height, border, format, type, gCHandle.AddrOfPinnedObject());
			pixels = (T8)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexImage3D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
	{
		Core.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
	}

	public static void TexImage3D<T9>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, [In][Out] T9[] pixels) where T9 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexImage3D<T9>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, [In][Out] T9[,] pixels) where T9 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexImage3D<T9>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, [In][Out] T9[,,] pixels) where T9 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexImage3D<T9>(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, [In][Out] ref T9 pixels) where T9 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, gCHandle.AddrOfPinnedObject());
			pixels = (T9)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexParameter(TextureTarget target, TextureParameterName pname, float param)
	{
		Core.TexParameterf(target, pname, param);
	}

	public unsafe static void TexParameter(TextureTarget target, TextureParameterName pname, float[] @params)
	{
		fixed (float* params2 = @params)
		{
			Core.TexParameterfv(target, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexParameter(TextureTarget target, TextureParameterName pname, float* @params)
	{
		Core.TexParameterfv(target, pname, @params);
	}

	public static void TexParameter(TextureTarget target, TextureParameterName pname, int param)
	{
		Core.TexParameteri(target, pname, param);
	}

	public unsafe static void TexParameter(TextureTarget target, TextureParameterName pname, int[] @params)
	{
		fixed (int* params2 = @params)
		{
			Core.TexParameteriv(target, pname, params2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void TexParameter(TextureTarget target, TextureParameterName pname, int* @params)
	{
		Core.TexParameteriv(target, pname, @params);
	}

	public static void TexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels)
	{
		Core.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
	}

	public static void TexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, [In][Out] T6[] pixels) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage1D(target, level, xoffset, width, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, [In][Out] T6[,] pixels) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage1D(target, level, xoffset, width, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, [In][Out] T6[,,] pixels) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage1D(target, level, xoffset, width, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexSubImage1D<T6>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, [In][Out] ref T6 pixels) where T6 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage1D(target, level, xoffset, width, format, type, gCHandle.AddrOfPinnedObject());
			pixels = (T6)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
	{
		Core.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
	}

	public static void TexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, [In][Out] T8[] pixels) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, [In][Out] T8[,] pixels) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, [In][Out] T8[,,] pixels) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexSubImage2D<T8>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, [In][Out] ref T8 pixels) where T8 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, gCHandle.AddrOfPinnedObject());
			pixels = (T8)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
	{
		Core.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
	}

	public static void TexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, [In][Out] T10[] pixels) where T10 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, [In][Out] T10[,] pixels) where T10 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, [In][Out] T10[,,] pixels) where T10 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void TexSubImage3D<T10>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, [In][Out] ref T10 pixels) where T10 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
		try
		{
			Core.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, gCHandle.AddrOfPinnedObject());
			pixels = (T10)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void Translate(double x, double y, double z)
	{
		Core.Translated(x, y, z);
	}

	public static void Translate(float x, float y, float z)
	{
		Core.Translatef(x, y, z);
	}

	public static void Uniform1(int location, float v0)
	{
		Core.Uniform1f(location, v0);
	}

	public unsafe static void Uniform1(int location, int count, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.Uniform1fv(location, count, value2);
		}
	}

	public unsafe static void Uniform1(int location, int count, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.Uniform1fv(location, count, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Uniform1(int location, int count, float* value)
	{
		Core.Uniform1fv(location, count, value);
	}

	public static void Uniform1(int location, int v0)
	{
		Core.Uniform1i(location, v0);
	}

	public unsafe static void Uniform1(int location, int count, int[] value)
	{
		fixed (int* value2 = value)
		{
			Core.Uniform1iv(location, count, value2);
		}
	}

	public unsafe static void Uniform1(int location, int count, ref int value)
	{
		fixed (int* value2 = &value)
		{
			Core.Uniform1iv(location, count, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Uniform1(int location, int count, int* value)
	{
		Core.Uniform1iv(location, count, value);
	}

	public static void Uniform2(int location, float v0, float v1)
	{
		Core.Uniform2f(location, v0, v1);
	}

	public unsafe static void Uniform2(int location, int count, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.Uniform2fv(location, count, value2);
		}
	}

	public unsafe static void Uniform2(int location, int count, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.Uniform2fv(location, count, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Uniform2(int location, int count, float* value)
	{
		Core.Uniform2fv(location, count, value);
	}

	public static void Uniform2(int location, int v0, int v1)
	{
		Core.Uniform2i(location, v0, v1);
	}

	public unsafe static void Uniform2(int location, int count, int[] value)
	{
		fixed (int* value2 = value)
		{
			Core.Uniform2iv(location, count, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Uniform2(int location, int count, int* value)
	{
		Core.Uniform2iv(location, count, value);
	}

	public static void Uniform3(int location, float v0, float v1, float v2)
	{
		Core.Uniform3f(location, v0, v1, v2);
	}

	public unsafe static void Uniform3(int location, int count, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.Uniform3fv(location, count, value2);
		}
	}

	public unsafe static void Uniform3(int location, int count, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.Uniform3fv(location, count, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Uniform3(int location, int count, float* value)
	{
		Core.Uniform3fv(location, count, value);
	}

	public static void Uniform3(int location, int v0, int v1, int v2)
	{
		Core.Uniform3i(location, v0, v1, v2);
	}

	public unsafe static void Uniform3(int location, int count, int[] value)
	{
		fixed (int* value2 = value)
		{
			Core.Uniform3iv(location, count, value2);
		}
	}

	public unsafe static void Uniform3(int location, int count, ref int value)
	{
		fixed (int* value2 = &value)
		{
			Core.Uniform3iv(location, count, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Uniform3(int location, int count, int* value)
	{
		Core.Uniform3iv(location, count, value);
	}

	public static void Uniform4(int location, float v0, float v1, float v2, float v3)
	{
		Core.Uniform4f(location, v0, v1, v2, v3);
	}

	public unsafe static void Uniform4(int location, int count, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.Uniform4fv(location, count, value2);
		}
	}

	public unsafe static void Uniform4(int location, int count, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.Uniform4fv(location, count, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Uniform4(int location, int count, float* value)
	{
		Core.Uniform4fv(location, count, value);
	}

	public static void Uniform4(int location, int v0, int v1, int v2, int v3)
	{
		Core.Uniform4i(location, v0, v1, v2, v3);
	}

	public unsafe static void Uniform4(int location, int count, int[] value)
	{
		fixed (int* value2 = value)
		{
			Core.Uniform4iv(location, count, value2);
		}
	}

	public unsafe static void Uniform4(int location, int count, ref int value)
	{
		fixed (int* value2 = &value)
		{
			Core.Uniform4iv(location, count, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Uniform4(int location, int count, int* value)
	{
		Core.Uniform4iv(location, count, value);
	}

	public unsafe static void UniformMatrix2(int location, int count, bool transpose, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.UniformMatrix2fv(location, count, transpose, value2);
		}
	}

	public unsafe static void UniformMatrix2(int location, int count, bool transpose, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.UniformMatrix2fv(location, count, transpose, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void UniformMatrix2(int location, int count, bool transpose, float* value)
	{
		Core.UniformMatrix2fv(location, count, transpose, value);
	}

	public unsafe static void UniformMatrix2x4(int location, int count, bool transpose, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.UniformMatrix2x4fv(location, count, transpose, value2);
		}
	}

	public unsafe static void UniformMatrix2x4(int location, int count, bool transpose, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.UniformMatrix2x4fv(location, count, transpose, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void UniformMatrix2x4(int location, int count, bool transpose, float* value)
	{
		Core.UniformMatrix2x4fv(location, count, transpose, value);
	}

	public unsafe static void UniformMatrix3(int location, int count, bool transpose, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.UniformMatrix3fv(location, count, transpose, value2);
		}
	}

	public unsafe static void UniformMatrix3(int location, int count, bool transpose, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.UniformMatrix3fv(location, count, transpose, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void UniformMatrix3(int location, int count, bool transpose, float* value)
	{
		Core.UniformMatrix3fv(location, count, transpose, value);
	}

	public unsafe static void UniformMatrix3x2(int location, int count, bool transpose, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.UniformMatrix3x2fv(location, count, transpose, value2);
		}
	}

	public unsafe static void UniformMatrix3x2(int location, int count, bool transpose, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.UniformMatrix3x2fv(location, count, transpose, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void UniformMatrix3x2(int location, int count, bool transpose, float* value)
	{
		Core.UniformMatrix3x2fv(location, count, transpose, value);
	}

	public unsafe static void UniformMatrix3x4(int location, int count, bool transpose, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.UniformMatrix3x4fv(location, count, transpose, value2);
		}
	}

	public unsafe static void UniformMatrix3x4(int location, int count, bool transpose, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.UniformMatrix3x4fv(location, count, transpose, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void UniformMatrix4(int location, int count, bool transpose, double* value)
	{
		Core.UniformMatrix4dv(location, count, transpose, value);
	}

	public unsafe static void UniformMatrix4(int location, int count, bool transpose, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.UniformMatrix4fv(location, count, transpose, value2);
		}
	}

	public unsafe static void UniformMatrix4(int location, int count, bool transpose, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.UniformMatrix4fv(location, count, transpose, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void UniformMatrix4(int location, int count, bool transpose, float* value)
	{
		Core.UniformMatrix4fv(location, count, transpose, value);
	}

	public unsafe static void UniformMatrix4x2(int location, int count, bool transpose, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.UniformMatrix4x2fv(location, count, transpose, value2);
		}
	}

	public unsafe static void UniformMatrix4x2(int location, int count, bool transpose, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.UniformMatrix4x2fv(location, count, transpose, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void UniformMatrix4x2(int location, int count, bool transpose, float* value)
	{
		Core.UniformMatrix4x2fv(location, count, transpose, value);
	}

	public unsafe static void UniformMatrix4x3(int location, int count, bool transpose, float[] value)
	{
		fixed (float* value2 = value)
		{
			Core.UniformMatrix4x3fv(location, count, transpose, value2);
		}
	}

	public unsafe static void UniformMatrix4x3(int location, int count, bool transpose, ref float value)
	{
		fixed (float* value2 = &value)
		{
			Core.UniformMatrix4x3fv(location, count, transpose, value2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void UniformMatrix4x3(int location, int count, bool transpose, float* value)
	{
		Core.UniformMatrix4x3fv(location, count, transpose, value);
	}

	public static bool UnmapBuffer(BufferTarget target)
	{
		return Core.UnmapBuffer(target);
	}

	public static void UseProgram(int program)
	{
		Core.UseProgram((uint)program);
	}

	[CLSCompliant(false)]
	public static void UseProgram(uint program)
	{
		Core.UseProgram(program);
	}

	public static void ValidateProgram(int program)
	{
		Core.ValidateProgram((uint)program);
	}

	[CLSCompliant(false)]
	public static void ValidateProgram(uint program)
	{
		Core.ValidateProgram(program);
	}

	public static void Vertex2(double x, double y)
	{
		Core.Vertex2d(x, y);
	}

	public unsafe static void Vertex2(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.Vertex2dv(v2);
		}
	}

	public unsafe static void Vertex2(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.Vertex2dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex2(double* v)
	{
		Core.Vertex2dv(v);
	}

	public static void Vertex2(float x, float y)
	{
		Core.Vertex2f(x, y);
	}

	public unsafe static void Vertex2(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.Vertex2fv(v2);
		}
	}

	public unsafe static void Vertex2(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.Vertex2fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex2(float* v)
	{
		Core.Vertex2fv(v);
	}

	public static void Vertex2(int x, int y)
	{
		Core.Vertex2i(x, y);
	}

	public unsafe static void Vertex2(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.Vertex2iv(v2);
		}
	}

	public unsafe static void Vertex2(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.Vertex2iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex2(int* v)
	{
		Core.Vertex2iv(v);
	}

	public static void Vertex2(short x, short y)
	{
		Core.Vertex2s(x, y);
	}

	public unsafe static void Vertex2(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.Vertex2sv(v2);
		}
	}

	public unsafe static void Vertex2(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.Vertex2sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex2(short* v)
	{
		Core.Vertex2sv(v);
	}

	public static void Vertex3(double x, double y, double z)
	{
		Core.Vertex3d(x, y, z);
	}

	public unsafe static void Vertex3(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.Vertex3dv(v2);
		}
	}

	public unsafe static void Vertex3(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.Vertex3dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex3(double* v)
	{
		Core.Vertex3dv(v);
	}

	public static void Vertex3(float x, float y, float z)
	{
		Core.Vertex3f(x, y, z);
	}

	public unsafe static void Vertex3(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.Vertex3fv(v2);
		}
	}

	public unsafe static void Vertex3(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.Vertex3fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex3(float* v)
	{
		Core.Vertex3fv(v);
	}

	public static void Vertex3(int x, int y, int z)
	{
		Core.Vertex3i(x, y, z);
	}

	public unsafe static void Vertex3(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.Vertex3iv(v2);
		}
	}

	public unsafe static void Vertex3(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.Vertex3iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex3(int* v)
	{
		Core.Vertex3iv(v);
	}

	public static void Vertex3(short x, short y, short z)
	{
		Core.Vertex3s(x, y, z);
	}

	public unsafe static void Vertex3(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.Vertex3sv(v2);
		}
	}

	public unsafe static void Vertex3(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.Vertex3sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex3(short* v)
	{
		Core.Vertex3sv(v);
	}

	public static void Vertex4(double x, double y, double z, double w)
	{
		Core.Vertex4d(x, y, z, w);
	}

	public unsafe static void Vertex4(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.Vertex4dv(v2);
		}
	}

	public unsafe static void Vertex4(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.Vertex4dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex4(double* v)
	{
		Core.Vertex4dv(v);
	}

	public static void Vertex4(float x, float y, float z, float w)
	{
		Core.Vertex4f(x, y, z, w);
	}

	public unsafe static void Vertex4(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.Vertex4fv(v2);
		}
	}

	public unsafe static void Vertex4(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.Vertex4fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex4(float* v)
	{
		Core.Vertex4fv(v);
	}

	public static void Vertex4(int x, int y, int z, int w)
	{
		Core.Vertex4i(x, y, z, w);
	}

	public unsafe static void Vertex4(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.Vertex4iv(v2);
		}
	}

	public unsafe static void Vertex4(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.Vertex4iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex4(int* v)
	{
		Core.Vertex4iv(v);
	}

	public static void Vertex4(short x, short y, short z, short w)
	{
		Core.Vertex4s(x, y, z, w);
	}

	public unsafe static void Vertex4(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.Vertex4sv(v2);
		}
	}

	public unsafe static void Vertex4(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.Vertex4sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void Vertex4(short* v)
	{
		Core.Vertex4sv(v);
	}

	public static void VertexAttrib1(int index, double x)
	{
		Core.VertexAttrib1d((uint)index, x);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib1(uint index, double x)
	{
		Core.VertexAttrib1d(index, x);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib1(int index, double* v)
	{
		Core.VertexAttrib1dv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib1(uint index, double* v)
	{
		Core.VertexAttrib1dv(index, v);
	}

	public static void VertexAttrib1(int index, float x)
	{
		Core.VertexAttrib1f((uint)index, x);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib1(uint index, float x)
	{
		Core.VertexAttrib1f(index, x);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib1(int index, float* v)
	{
		Core.VertexAttrib1fv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib1(uint index, float* v)
	{
		Core.VertexAttrib1fv(index, v);
	}

	public static void VertexAttrib1(int index, short x)
	{
		Core.VertexAttrib1s((uint)index, x);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib1(uint index, short x)
	{
		Core.VertexAttrib1s(index, x);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib1(int index, short* v)
	{
		Core.VertexAttrib1sv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib1(uint index, short* v)
	{
		Core.VertexAttrib1sv(index, v);
	}

	public static void VertexAttrib2(int index, double x, double y)
	{
		Core.VertexAttrib2d((uint)index, x, y);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib2(uint index, double x, double y)
	{
		Core.VertexAttrib2d(index, x, y);
	}

	public unsafe static void VertexAttrib2(int index, double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.VertexAttrib2dv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib2(int index, ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.VertexAttrib2dv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(int index, double* v)
	{
		Core.VertexAttrib2dv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(uint index, double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.VertexAttrib2dv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(uint index, ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.VertexAttrib2dv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(uint index, double* v)
	{
		Core.VertexAttrib2dv(index, v);
	}

	public static void VertexAttrib2(int index, float x, float y)
	{
		Core.VertexAttrib2f((uint)index, x, y);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib2(uint index, float x, float y)
	{
		Core.VertexAttrib2f(index, x, y);
	}

	public unsafe static void VertexAttrib2(int index, float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.VertexAttrib2fv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib2(int index, ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.VertexAttrib2fv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(int index, float* v)
	{
		Core.VertexAttrib2fv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(uint index, float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.VertexAttrib2fv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(uint index, ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.VertexAttrib2fv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(uint index, float* v)
	{
		Core.VertexAttrib2fv(index, v);
	}

	public static void VertexAttrib2(int index, short x, short y)
	{
		Core.VertexAttrib2s((uint)index, x, y);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib2(uint index, short x, short y)
	{
		Core.VertexAttrib2s(index, x, y);
	}

	public unsafe static void VertexAttrib2(int index, short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.VertexAttrib2sv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib2(int index, ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.VertexAttrib2sv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(int index, short* v)
	{
		Core.VertexAttrib2sv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(uint index, short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.VertexAttrib2sv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(uint index, ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.VertexAttrib2sv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib2(uint index, short* v)
	{
		Core.VertexAttrib2sv(index, v);
	}

	public static void VertexAttrib3(int index, double x, double y, double z)
	{
		Core.VertexAttrib3d((uint)index, x, y, z);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib3(uint index, double x, double y, double z)
	{
		Core.VertexAttrib3d(index, x, y, z);
	}

	public unsafe static void VertexAttrib3(int index, double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.VertexAttrib3dv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib3(int index, ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.VertexAttrib3dv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(int index, double* v)
	{
		Core.VertexAttrib3dv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(uint index, double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.VertexAttrib3dv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(uint index, ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.VertexAttrib3dv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(uint index, double* v)
	{
		Core.VertexAttrib3dv(index, v);
	}

	public static void VertexAttrib3(int index, float x, float y, float z)
	{
		Core.VertexAttrib3f((uint)index, x, y, z);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib3(uint index, float x, float y, float z)
	{
		Core.VertexAttrib3f(index, x, y, z);
	}

	public unsafe static void VertexAttrib3(int index, float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.VertexAttrib3fv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib3(int index, ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.VertexAttrib3fv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(int index, float* v)
	{
		Core.VertexAttrib3fv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(uint index, float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.VertexAttrib3fv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(uint index, ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.VertexAttrib3fv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(uint index, float* v)
	{
		Core.VertexAttrib3fv(index, v);
	}

	public static void VertexAttrib3(int index, short x, short y, short z)
	{
		Core.VertexAttrib3s((uint)index, x, y, z);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib3(uint index, short x, short y, short z)
	{
		Core.VertexAttrib3s(index, x, y, z);
	}

	public unsafe static void VertexAttrib3(int index, short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.VertexAttrib3sv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib3(int index, ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.VertexAttrib3sv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(int index, short* v)
	{
		Core.VertexAttrib3sv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(uint index, short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.VertexAttrib3sv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(uint index, ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.VertexAttrib3sv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib3(uint index, short* v)
	{
		Core.VertexAttrib3sv(index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, sbyte[] v)
	{
		fixed (sbyte* v2 = v)
		{
			Core.VertexAttrib4bv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, ref sbyte v)
	{
		fixed (sbyte* v2 = &v)
		{
			Core.VertexAttrib4bv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, sbyte* v)
	{
		Core.VertexAttrib4bv(index, v);
	}

	public static void VertexAttrib4(int index, double x, double y, double z, double w)
	{
		Core.VertexAttrib4d((uint)index, x, y, z, w);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib4(uint index, double x, double y, double z, double w)
	{
		Core.VertexAttrib4d(index, x, y, z, w);
	}

	public unsafe static void VertexAttrib4(int index, double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.VertexAttrib4dv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib4(int index, ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.VertexAttrib4dv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(int index, double* v)
	{
		Core.VertexAttrib4dv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.VertexAttrib4dv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.VertexAttrib4dv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, double* v)
	{
		Core.VertexAttrib4dv(index, v);
	}

	public static void VertexAttrib4(int index, float x, float y, float z, float w)
	{
		Core.VertexAttrib4f((uint)index, x, y, z, w);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib4(uint index, float x, float y, float z, float w)
	{
		Core.VertexAttrib4f(index, x, y, z, w);
	}

	public unsafe static void VertexAttrib4(int index, float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.VertexAttrib4fv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib4(int index, ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.VertexAttrib4fv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(int index, float* v)
	{
		Core.VertexAttrib4fv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.VertexAttrib4fv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.VertexAttrib4fv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, float* v)
	{
		Core.VertexAttrib4fv(index, v);
	}

	public unsafe static void VertexAttrib4(int index, int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.VertexAttrib4iv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib4(int index, ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.VertexAttrib4iv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(int index, int* v)
	{
		Core.VertexAttrib4iv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.VertexAttrib4iv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.VertexAttrib4iv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, int* v)
	{
		Core.VertexAttrib4iv(index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, sbyte[] v)
	{
		fixed (sbyte* v2 = v)
		{
			Core.VertexAttrib4Nbv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, ref sbyte v)
	{
		fixed (sbyte* v2 = &v)
		{
			Core.VertexAttrib4Nbv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, sbyte* v)
	{
		Core.VertexAttrib4Nbv(index, v);
	}

	public unsafe static void VertexAttrib4N(int index, int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.VertexAttrib4Niv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib4N(int index, ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.VertexAttrib4Niv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(int index, int* v)
	{
		Core.VertexAttrib4Niv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.VertexAttrib4Niv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.VertexAttrib4Niv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, int* v)
	{
		Core.VertexAttrib4Niv(index, v);
	}

	public unsafe static void VertexAttrib4N(int index, short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.VertexAttrib4Nsv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib4N(int index, ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.VertexAttrib4Nsv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(int index, short* v)
	{
		Core.VertexAttrib4Nsv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.VertexAttrib4Nsv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.VertexAttrib4Nsv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, short* v)
	{
		Core.VertexAttrib4Nsv(index, v);
	}

	public static void VertexAttrib4N(int index, byte x, byte y, byte z, byte w)
	{
		Core.VertexAttrib4Nub((uint)index, x, y, z, w);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib4N(uint index, byte x, byte y, byte z, byte w)
	{
		Core.VertexAttrib4Nub(index, x, y, z, w);
	}

	public unsafe static void VertexAttrib4N(int index, byte[] v)
	{
		fixed (byte* v2 = v)
		{
			Core.VertexAttrib4Nubv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib4N(int index, ref byte v)
	{
		fixed (byte* v2 = &v)
		{
			Core.VertexAttrib4Nubv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(int index, byte* v)
	{
		Core.VertexAttrib4Nubv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, byte[] v)
	{
		fixed (byte* v2 = v)
		{
			Core.VertexAttrib4Nubv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, ref byte v)
	{
		fixed (byte* v2 = &v)
		{
			Core.VertexAttrib4Nubv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, byte* v)
	{
		Core.VertexAttrib4Nubv(index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, uint[] v)
	{
		fixed (uint* v2 = v)
		{
			Core.VertexAttrib4Nuiv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, ref uint v)
	{
		fixed (uint* v2 = &v)
		{
			Core.VertexAttrib4Nuiv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, uint* v)
	{
		Core.VertexAttrib4Nuiv(index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, ushort[] v)
	{
		fixed (ushort* v2 = v)
		{
			Core.VertexAttrib4Nusv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, ref ushort v)
	{
		fixed (ushort* v2 = &v)
		{
			Core.VertexAttrib4Nusv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4N(uint index, ushort* v)
	{
		Core.VertexAttrib4Nusv(index, v);
	}

	public static void VertexAttrib4(int index, short x, short y, short z, short w)
	{
		Core.VertexAttrib4s((uint)index, x, y, z, w);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib4(uint index, short x, short y, short z, short w)
	{
		Core.VertexAttrib4s(index, x, y, z, w);
	}

	public unsafe static void VertexAttrib4(int index, short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.VertexAttrib4sv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib4(int index, ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.VertexAttrib4sv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(int index, short* v)
	{
		Core.VertexAttrib4sv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.VertexAttrib4sv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.VertexAttrib4sv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, short* v)
	{
		Core.VertexAttrib4sv(index, v);
	}

	public unsafe static void VertexAttrib4(int index, byte[] v)
	{
		fixed (byte* v2 = v)
		{
			Core.VertexAttrib4ubv((uint)index, v2);
		}
	}

	public unsafe static void VertexAttrib4(int index, ref byte v)
	{
		fixed (byte* v2 = &v)
		{
			Core.VertexAttrib4ubv((uint)index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(int index, byte* v)
	{
		Core.VertexAttrib4ubv((uint)index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, byte[] v)
	{
		fixed (byte* v2 = v)
		{
			Core.VertexAttrib4ubv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, ref byte v)
	{
		fixed (byte* v2 = &v)
		{
			Core.VertexAttrib4ubv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, byte* v)
	{
		Core.VertexAttrib4ubv(index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, uint[] v)
	{
		fixed (uint* v2 = v)
		{
			Core.VertexAttrib4uiv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, ref uint v)
	{
		fixed (uint* v2 = &v)
		{
			Core.VertexAttrib4uiv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, uint* v)
	{
		Core.VertexAttrib4uiv(index, v);
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, ushort[] v)
	{
		fixed (ushort* v2 = v)
		{
			Core.VertexAttrib4usv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, ref ushort v)
	{
		fixed (ushort* v2 = &v)
		{
			Core.VertexAttrib4usv(index, v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void VertexAttrib4(uint index, ushort* v)
	{
		Core.VertexAttrib4usv(index, v);
	}

	public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, IntPtr pointer)
	{
		Core.VertexAttribPointer((uint)index, size, type, normalized, stride, pointer);
	}

	public static void VertexAttribPointer<T5>(int index, int size, VertexAttribPointerType type, bool normalized, int stride, [In][Out] T5[] pointer) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexAttribPointer((uint)index, size, type, normalized, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void VertexAttribPointer<T5>(int index, int size, VertexAttribPointerType type, bool normalized, int stride, [In][Out] T5[,] pointer) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexAttribPointer((uint)index, size, type, normalized, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void VertexAttribPointer<T5>(int index, int size, VertexAttribPointerType type, bool normalized, int stride, [In][Out] T5[,,] pointer) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexAttribPointer((uint)index, size, type, normalized, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void VertexAttribPointer<T5>(int index, int size, VertexAttribPointerType type, bool normalized, int stride, [In][Out] ref T5 pointer) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexAttribPointer((uint)index, size, type, normalized, stride, gCHandle.AddrOfPinnedObject());
			pointer = (T5)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, IntPtr pointer)
	{
		Core.VertexAttribPointer(index, size, type, normalized, stride, pointer);
	}

	[CLSCompliant(false)]
	public static void VertexAttribPointer<T5>(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, [In][Out] T5[] pointer) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexAttribPointer(index, size, type, normalized, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void VertexAttribPointer<T5>(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, [In][Out] T5[,] pointer) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexAttribPointer(index, size, type, normalized, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void VertexAttribPointer<T5>(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, [In][Out] T5[,,] pointer) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexAttribPointer(index, size, type, normalized, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[CLSCompliant(false)]
	public static void VertexAttribPointer<T5>(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, [In][Out] ref T5 pointer) where T5 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexAttribPointer(index, size, type, normalized, stride, gCHandle.AddrOfPinnedObject());
			pointer = (T5)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void VertexPointer(int size, VertexPointerType type, int stride, IntPtr pointer)
	{
		Core.VertexPointer(size, type, stride, pointer);
	}

	public static void VertexPointer<T3>(int size, VertexPointerType type, int stride, [In][Out] T3[] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void VertexPointer<T3>(int size, VertexPointerType type, int stride, [In][Out] T3[,] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void VertexPointer<T3>(int size, VertexPointerType type, int stride, [In][Out] T3[,,] pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void VertexPointer<T3>(int size, VertexPointerType type, int stride, [In][Out] ref T3 pointer) where T3 : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(pointer, GCHandleType.Pinned);
		try
		{
			Core.VertexPointer(size, type, stride, gCHandle.AddrOfPinnedObject());
			pointer = (T3)gCHandle.Target;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void Viewport(int x, int y, int width, int height)
	{
		Core.Viewport(x, y, width, height);
	}

	public static void WindowPos2(double x, double y)
	{
		Core.WindowPos2d(x, y);
	}

	public unsafe static void WindowPos2(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.WindowPos2dv(v2);
		}
	}

	public unsafe static void WindowPos2(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.WindowPos2dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void WindowPos2(double* v)
	{
		Core.WindowPos2dv(v);
	}

	public static void WindowPos2(float x, float y)
	{
		Core.WindowPos2f(x, y);
	}

	public unsafe static void WindowPos2(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.WindowPos2fv(v2);
		}
	}

	public unsafe static void WindowPos2(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.WindowPos2fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void WindowPos2(float* v)
	{
		Core.WindowPos2fv(v);
	}

	public static void WindowPos2(int x, int y)
	{
		Core.WindowPos2i(x, y);
	}

	public unsafe static void WindowPos2(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.WindowPos2iv(v2);
		}
	}

	public unsafe static void WindowPos2(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.WindowPos2iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void WindowPos2(int* v)
	{
		Core.WindowPos2iv(v);
	}

	public static void WindowPos2(short x, short y)
	{
		Core.WindowPos2s(x, y);
	}

	public unsafe static void WindowPos2(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.WindowPos2sv(v2);
		}
	}

	public unsafe static void WindowPos2(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.WindowPos2sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void WindowPos2(short* v)
	{
		Core.WindowPos2sv(v);
	}

	public static void WindowPos3(double x, double y, double z)
	{
		Core.WindowPos3d(x, y, z);
	}

	public unsafe static void WindowPos3(double[] v)
	{
		fixed (double* v2 = v)
		{
			Core.WindowPos3dv(v2);
		}
	}

	public unsafe static void WindowPos3(ref double v)
	{
		fixed (double* v2 = &v)
		{
			Core.WindowPos3dv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void WindowPos3(double* v)
	{
		Core.WindowPos3dv(v);
	}

	public static void WindowPos3(float x, float y, float z)
	{
		Core.WindowPos3f(x, y, z);
	}

	public unsafe static void WindowPos3(float[] v)
	{
		fixed (float* v2 = v)
		{
			Core.WindowPos3fv(v2);
		}
	}

	public unsafe static void WindowPos3(ref float v)
	{
		fixed (float* v2 = &v)
		{
			Core.WindowPos3fv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void WindowPos3(float* v)
	{
		Core.WindowPos3fv(v);
	}

	public static void WindowPos3(int x, int y, int z)
	{
		Core.WindowPos3i(x, y, z);
	}

	public unsafe static void WindowPos3(int[] v)
	{
		fixed (int* v2 = v)
		{
			Core.WindowPos3iv(v2);
		}
	}

	public unsafe static void WindowPos3(ref int v)
	{
		fixed (int* v2 = &v)
		{
			Core.WindowPos3iv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void WindowPos3(int* v)
	{
		Core.WindowPos3iv(v);
	}

	public static void WindowPos3(short x, short y, short z)
	{
		Core.WindowPos3s(x, y, z);
	}

	public unsafe static void WindowPos3(short[] v)
	{
		fixed (short* v2 = v)
		{
			Core.WindowPos3sv(v2);
		}
	}

	public unsafe static void WindowPos3(ref short v)
	{
		fixed (short* v2 = &v)
		{
			Core.WindowPos3sv(v2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void WindowPos3(short* v)
	{
		Core.WindowPos3sv(v);
	}

	public static void BindFramebuffer(FramebufferTarget target, int framebuffer)
	{
		Core.BindFramebufferEXT(target, (uint)framebuffer);
	}

	public static void BindFramebuffer(FramebufferTarget target, uint framebuffer)
	{
		Core.BindFramebufferEXT(target, framebuffer);
	}

	public static void BindRenderbuffer(RenderbufferTarget target, int renderbuffer)
	{
		Core.BindRenderbufferEXT(target, (uint)renderbuffer);
	}

	public static void BindRenderbuffer(RenderbufferTarget target, uint renderbuffer)
	{
		Core.BindRenderbufferEXT(target, renderbuffer);
	}

	public static FramebufferErrorCode CheckFramebufferStatus(FramebufferTarget target)
	{
		return Core.CheckFramebufferStatusEXT(target);
	}

	public unsafe static void DeleteFramebuffers(int n, int[] framebuffers)
	{
		fixed (int* framebuffers2 = framebuffers)
		{
			Core.DeleteFramebuffersEXT(n, (uint*)framebuffers2);
		}
	}

	public unsafe static void DeleteFramebuffers(int n, ref int framebuffers)
	{
		fixed (int* framebuffers2 = &framebuffers)
		{
			Core.DeleteFramebuffersEXT(n, (uint*)framebuffers2);
		}
	}

	public unsafe static void DeleteFramebuffers(int n, int* framebuffers)
	{
		Core.DeleteFramebuffersEXT(n, (uint*)framebuffers);
	}

	public unsafe static void DeleteFramebuffers(int n, uint[] framebuffers)
	{
		fixed (uint* framebuffers2 = framebuffers)
		{
			Core.DeleteFramebuffersEXT(n, framebuffers2);
		}
	}

	public unsafe static void DeleteFramebuffers(int n, ref uint framebuffers)
	{
		fixed (uint* framebuffers2 = &framebuffers)
		{
			Core.DeleteFramebuffersEXT(n, framebuffers2);
		}
	}

	public unsafe static void DeleteFramebuffers(int n, uint* framebuffers)
	{
		Core.DeleteFramebuffersEXT(n, framebuffers);
	}

	public unsafe static void DeleteRenderbuffers(int n, int[] renderbuffers)
	{
		fixed (int* renderbuffers2 = renderbuffers)
		{
			Core.DeleteRenderbuffersEXT(n, (uint*)renderbuffers2);
		}
	}

	public unsafe static void DeleteRenderbuffers(int n, ref int renderbuffers)
	{
		fixed (int* renderbuffers2 = &renderbuffers)
		{
			Core.DeleteRenderbuffersEXT(n, (uint*)renderbuffers2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteRenderbuffers(int n, int* renderbuffers)
	{
		Core.DeleteRenderbuffersEXT(n, (uint*)renderbuffers);
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteRenderbuffers(int n, uint[] renderbuffers)
	{
		fixed (uint* renderbuffers2 = renderbuffers)
		{
			Core.DeleteRenderbuffersEXT(n, renderbuffers2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteRenderbuffers(int n, ref uint renderbuffers)
	{
		fixed (uint* renderbuffers2 = &renderbuffers)
		{
			Core.DeleteRenderbuffersEXT(n, renderbuffers2);
		}
	}

	[CLSCompliant(false)]
	public unsafe static void DeleteRenderbuffers(int n, uint* renderbuffers)
	{
		Core.DeleteRenderbuffersEXT(n, renderbuffers);
	}

	public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer)
	{
		Core.FramebufferRenderbufferEXT(target, attachment, renderbuffertarget, (uint)renderbuffer);
	}

	public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
	{
		Core.FramebufferRenderbufferEXT(target, attachment, renderbuffertarget, renderbuffer);
	}

	public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level)
	{
		Core.FramebufferTexture1DEXT(target, attachment, textarget, (uint)texture, level);
	}

	public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
	{
		Core.FramebufferTexture1DEXT(target, attachment, textarget, texture, level);
	}

	public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level)
	{
		Core.FramebufferTexture2DEXT(target, attachment, textarget, (uint)texture, level);
	}

	[CLSCompliant(false)]
	public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
	{
		Core.FramebufferTexture2DEXT(target, attachment, textarget, texture, level);
	}

	public static void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int zoffset)
	{
		Core.FramebufferTexture3DEXT(target, attachment, textarget, (uint)texture, level, zoffset);
	}

	[CLSCompliant(false)]
	public static void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset)
	{
		Core.FramebufferTexture3DEXT(target, attachment, textarget, texture, level, zoffset);
	}

	public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level)
	{
		Core.FramebufferTextureEXT(target, attachment, (uint)texture, level);
	}

	public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level)
	{
		Core.FramebufferTextureEXT(target, attachment, texture, level);
	}

	public static void FramebufferTextureFace(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, TextureTarget face)
	{
		Core.FramebufferTextureFaceEXT(target, attachment, (uint)texture, level, face);
	}

	[CLSCompliant(false)]
	public static void FramebufferTextureFace(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, TextureTarget face)
	{
		Core.FramebufferTextureFaceEXT(target, attachment, texture, level, face);
	}

	public unsafe static void GenFramebuffers(int n, [Out] int[] framebuffers)
	{
		fixed (int* framebuffers2 = framebuffers)
		{
			Core.GenFramebuffersEXT(n, (uint*)framebuffers2);
		}
	}

	public unsafe static void GenFramebuffers(int n, out int framebuffers)
	{
		fixed (int* ptr = &framebuffers)
		{
			Core.GenFramebuffersEXT(n, (uint*)ptr);
			framebuffers = *ptr;
		}
	}

	public unsafe static void GenFramebuffers(int n, [Out] int* framebuffers)
	{
		Core.GenFramebuffersEXT(n, (uint*)framebuffers);
	}

	public unsafe static void GenFramebuffers(int n, [Out] uint[] framebuffers)
	{
		fixed (uint* framebuffers2 = framebuffers)
		{
			Core.GenFramebuffersEXT(n, framebuffers2);
		}
	}

	public unsafe static void GenFramebuffers(int n, out uint framebuffers)
	{
		fixed (uint* ptr = &framebuffers)
		{
			Core.GenFramebuffersEXT(n, ptr);
			framebuffers = *ptr;
		}
	}

	public unsafe static void GenFramebuffers(int n, [Out] uint* framebuffers)
	{
		Core.GenFramebuffersEXT(n, framebuffers);
	}

	public unsafe static void GenRenderbuffers(int n, [Out] int[] renderbuffers)
	{
		fixed (int* renderbuffers2 = renderbuffers)
		{
			Core.GenRenderbuffersEXT(n, (uint*)renderbuffers2);
		}
	}

	public unsafe static void GenRenderbuffers(int n, out int renderbuffers)
	{
		fixed (int* ptr = &renderbuffers)
		{
			Core.GenRenderbuffersEXT(n, (uint*)ptr);
			renderbuffers = *ptr;
		}
	}

	public unsafe static void GenRenderbuffers(int n, [Out] int* renderbuffers)
	{
		Core.GenRenderbuffersEXT(n, (uint*)renderbuffers);
	}

	public unsafe static void GenRenderbuffers(int n, [Out] uint[] renderbuffers)
	{
		fixed (uint* renderbuffers2 = renderbuffers)
		{
			Core.GenRenderbuffersEXT(n, renderbuffers2);
		}
	}

	public unsafe static void GenRenderbuffers(int n, out uint renderbuffers)
	{
		fixed (uint* ptr = &renderbuffers)
		{
			Core.GenRenderbuffersEXT(n, ptr);
			renderbuffers = *ptr;
		}
	}

	public unsafe static void GenRenderbuffers(int n, [Out] uint* renderbuffers)
	{
		Core.GenRenderbuffersEXT(n, renderbuffers);
	}

	public static bool IsFramebuffer(int framebuffer)
	{
		return Core.IsFramebufferEXT((uint)framebuffer);
	}

	public static bool IsFramebuffer(uint framebuffer)
	{
		return Core.IsFramebufferEXT(framebuffer);
	}

	public static bool IsRenderbuffer(int renderbuffer)
	{
		return Core.IsRenderbufferEXT((uint)renderbuffer);
	}

	public static bool IsRenderbuffer(uint renderbuffer)
	{
		return Core.IsRenderbufferEXT(renderbuffer);
	}

	public static void ProgramParameter(int program, AssemblyProgramParameterArb pname, int value)
	{
		Core.ProgramParameteriEXT((uint)program, pname, value);
	}

	[CLSCompliant(false)]
	public static void ProgramParameter(uint program, AssemblyProgramParameterArb pname, int value)
	{
		Core.ProgramParameteriEXT(program, pname, value);
	}

	public static void RenderbufferStorage(RenderbufferTarget target, RenderbufferStorage internalformat, int width, int height)
	{
		Core.RenderbufferStorageEXT(target, internalformat, width, height);
	}

	public unsafe static void DeleteProgram(int n, int[] programs)
	{
		fixed (int* programs2 = programs)
		{
			Core.DeleteProgramsNV(n, (uint*)programs2);
		}
	}

	public unsafe static void DeleteProgram(int n, ref int programs)
	{
		fixed (int* programs2 = &programs)
		{
			Core.DeleteProgramsNV(n, (uint*)programs2);
		}
	}

	public static bool IsProgram(int id)
	{
		return Core.IsProgramNV((uint)id);
	}

	[CLSCompliant(false)]
	public static bool IsProgram(uint id)
	{
		return Core.IsProgramNV(id);
	}

	static GL()
	{
		sync_root = new object();
	}

	public static void Color3(Color color)
	{
		Color3(color.R, color.G, color.B);
	}

	public static void Color4(Color color)
	{
		Color4(color.R, color.G, color.B, color.A);
	}

	public static void Color3(NSColor color)
	{
		Color3(color.RedComponent, color.GreenComponent, color.BlueComponent);
	}

	public static void Color4(NSColor color)
	{
		Color4(color.RedComponent, color.GreenComponent, color.BlueComponent, color.AlphaComponent);
	}

	public static void Color3(Vector3 color)
	{
		Color3(color.X, color.Y, color.Z);
	}

	public static void Color4(Vector4 color)
	{
		Color4(color.X, color.Y, color.Z, color.W);
	}

	public static void Color4(Color4 color)
	{
		Color4(color.R, color.G, color.B, color.A);
	}

	public static void ClearColor(Color color)
	{
		ClearColor((float)(int)color.R / 255f, (float)(int)color.G / 255f, (float)(int)color.B / 255f, (float)(int)color.A / 255f);
	}

	public static void ClearColor(NSColor color)
	{
		ClearColor((float)color.RedComponent, (float)color.GreenComponent, (float)color.BlueComponent, (float)color.AlphaComponent);
	}

	public static void ClearColor(Color4 color)
	{
		ClearColor(color.R, color.G, color.B, color.A);
	}

	public static void BlendColor(Color color)
	{
		BlendColor((float)(int)color.R / 255f, (float)(int)color.G / 255f, (float)(int)color.B / 255f, (float)(int)color.A / 255f);
	}

	public static void BlendColor(NSColor color)
	{
		BlendColor((float)color.RedComponent, (float)color.GreenComponent, (float)color.BlueComponent, (float)color.AlphaComponent);
	}

	public static void BlendColor(Color4 color)
	{
		BlendColor(color.R, color.G, color.B, color.A);
	}

	public unsafe static void Material(MaterialFace face, MaterialParameter pname, Vector4 @params)
	{
		Material(face, pname, &@params.X);
	}

	public unsafe static void Material(MaterialFace face, MaterialParameter pname, Color4 @params)
	{
		Material(face, pname, (float*)(&@params));
	}

	public unsafe static void Light(LightName name, LightParameter pname, Vector4 @params)
	{
		Light(name, pname, &@params.X);
	}

	public unsafe static void Light(LightName name, LightParameter pname, Color4 @params)
	{
		Light(name, pname, (float*)(&@params));
	}

	public static void Normal3(Vector3 normal)
	{
		Normal3(normal.X, normal.Y, normal.Z);
	}

	public static void RasterPos2(Vector2 pos)
	{
		RasterPos2(pos.X, pos.Y);
	}

	public static void RasterPos3(Vector3 pos)
	{
		RasterPos3(pos.X, pos.Y, pos.Z);
	}

	public static void RasterPos4(Vector4 pos)
	{
		RasterPos4(pos.X, pos.Y, pos.Z, pos.W);
	}

	public static void Vertex2(Vector2 v)
	{
		Vertex2(v.X, v.Y);
	}

	public static void Vertex3(Vector3 v)
	{
		Vertex3(v.X, v.Y, v.Z);
	}

	public static void Vertex4(Vector4 v)
	{
		Vertex4(v.X, v.Y, v.Z, v.W);
	}

	public static void TexCoord2(Vector2 v)
	{
		TexCoord2(v.X, v.Y);
	}

	public static void TexCoord3(Vector3 v)
	{
		TexCoord3(v.X, v.Y, v.Z);
	}

	public static void TexCoord4(Vector4 v)
	{
		TexCoord4(v.X, v.Y, v.Z, v.W);
	}

	public static void Rotate(float angle, Vector3 axis)
	{
		Rotate(angle, axis.X, axis.Y, axis.Z);
	}

	public static void Scale(Vector3 scale)
	{
		Scale(scale.X, scale.Y, scale.Z);
	}

	public static void Translate(Vector3 trans)
	{
		Translate(trans.X, trans.Y, trans.Z);
	}

	public unsafe static void MultMatrix(ref Matrix4 mat)
	{
		fixed (float* m = &mat.Row0.X)
		{
			MultMatrix(m);
		}
	}

	public unsafe static void LoadMatrix(ref Matrix4 mat)
	{
		fixed (float* m = &mat.Row0.X)
		{
			LoadMatrix(m);
		}
	}

	public unsafe static void LoadTransposeMatrix(ref Matrix4 mat)
	{
		fixed (float* m = &mat.Row0.X)
		{
			LoadTransposeMatrix(m);
		}
	}

	public unsafe static void MultTransposeMatrix(ref Matrix4 mat)
	{
		fixed (float* m = &mat.Row0.X)
		{
			MultTransposeMatrix(m);
		}
	}

	public unsafe static void UniformMatrix4(int location, bool transpose, ref Matrix4 matrix)
	{
		fixed (float* value = &matrix.Row0.X)
		{
			UniformMatrix4(location, 1, transpose, value);
		}
	}

	public static void Normal3(Vector3d normal)
	{
		Normal3(normal.X, normal.Y, normal.Z);
	}

	public static void RasterPos2(Vector2d pos)
	{
		RasterPos2(pos.X, pos.Y);
	}

	public static void RasterPos3(Vector3d pos)
	{
		RasterPos3(pos.X, pos.Y, pos.Z);
	}

	public static void RasterPos4(Vector4d pos)
	{
		RasterPos4(pos.X, pos.Y, pos.Z, pos.W);
	}

	public static void Vertex2(Vector2d v)
	{
		Vertex2(v.X, v.Y);
	}

	public static void Vertex3(Vector3d v)
	{
		Vertex3(v.X, v.Y, v.Z);
	}

	public static void Vertex4(Vector4d v)
	{
		Vertex4(v.X, v.Y, v.Z, v.W);
	}

	public static void TexCoord2(Vector2d v)
	{
		TexCoord2(v.X, v.Y);
	}

	public static void TexCoord3(Vector3d v)
	{
		TexCoord3(v.X, v.Y, v.Z);
	}

	public static void TexCoord4(Vector4d v)
	{
		TexCoord4(v.X, v.Y, v.Z, v.W);
	}

	public static void Rotate(double angle, Vector3d axis)
	{
		Rotate(angle, axis.X, axis.Y, axis.Z);
	}

	public static void Scale(Vector3d scale)
	{
		Scale(scale.X, scale.Y, scale.Z);
	}

	public static void Translate(Vector3d trans)
	{
		Translate(trans.X, trans.Y, trans.Z);
	}

	public unsafe static void MultMatrix(ref Matrix4d mat)
	{
		fixed (double* m = &mat.Row0.X)
		{
			MultMatrix(m);
		}
	}

	public unsafe static void LoadMatrix(ref Matrix4d mat)
	{
		fixed (double* m = &mat.Row0.X)
		{
			LoadMatrix(m);
		}
	}

	public unsafe static void LoadTransposeMatrix(ref Matrix4d mat)
	{
		fixed (double* m = &mat.Row0.X)
		{
			LoadTransposeMatrix(m);
		}
	}

	public unsafe static void MultTransposeMatrix(ref Matrix4d mat)
	{
		fixed (double* m = &mat.Row0.X)
		{
			MultTransposeMatrix(m);
		}
	}

	[CLSCompliant(false)]
	public static void Uniform2(int location, ref Vector2 vector)
	{
		Uniform2(location, vector.X, vector.Y);
	}

	[CLSCompliant(false)]
	public static void Uniform3(int location, ref Vector3 vector)
	{
		Uniform3(location, vector.X, vector.Y, vector.Z);
	}

	[CLSCompliant(false)]
	public static void Uniform4(int location, ref Vector4 vector)
	{
		Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
	}

	public static void Uniform2(int location, Vector2 vector)
	{
		Uniform2(location, vector.X, vector.Y);
	}

	public static void Uniform3(int location, Vector3 vector)
	{
		Uniform3(location, vector.X, vector.Y, vector.Z);
	}

	public static void Uniform4(int location, Vector4 vector)
	{
		Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
	}

	public static void Uniform4(int location, Color4 color)
	{
		Uniform4(location, color.R, color.G, color.B, color.A);
	}

	public static void Uniform4(int location, Quaternion quaternion)
	{
		Uniform4(location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
	}

	public static string GetActiveAttrib(int program, int index, out int size, out ActiveAttribType type)
	{
		GetProgram(program, OpenGL.ProgramParameter.ActiveAttributeMaxLength, out var @params);
		StringBuilder stringBuilder = new StringBuilder((@params == 0) ? 1 : (@params * 2));
		GetActiveAttrib(program, index, stringBuilder.Capacity, out @params, out size, out type, stringBuilder);
		return stringBuilder.ToString();
	}

	public static string GetActiveUniform(int program, int uniformIndex, out int size, out ActiveUniformType type)
	{
		GetProgram(program, OpenGL.ProgramParameter.ActiveUniformMaxLength, out var @params);
		StringBuilder stringBuilder = new StringBuilder((@params == 0) ? 1 : @params);
		GetActiveUniform(program, uniformIndex, stringBuilder.Capacity, out @params, out size, out type, stringBuilder);
		return stringBuilder.ToString();
	}

	public unsafe static void ShaderSource(int shader, string @string)
	{
		int length = @string.Length;
		ShaderSource((uint)shader, 1, new string[1] { @string }, &length);
	}

	public static string GetShaderInfoLog(int shader)
	{
		GetShaderInfoLog(shader, out var info);
		return info;
	}

	public unsafe static void GetShaderInfoLog(int shader, out string info)
	{
		GetShader(shader, ShaderParameter.InfoLogLength, out var @params);
		if (@params == 0)
		{
			info = string.Empty;
			return;
		}
		StringBuilder stringBuilder = new StringBuilder(@params * 2);
		GetShaderInfoLog((uint)shader, stringBuilder.Capacity, &@params, stringBuilder);
		info = stringBuilder.ToString();
	}

	public static string GetProgramInfoLog(int program)
	{
		GetProgramInfoLog(program, out var info);
		return info;
	}

	public unsafe static void GetProgramInfoLog(int program, out string info)
	{
		GetProgram(program, OpenGL.ProgramParameter.InfoLogLength, out var @params);
		if (@params == 0)
		{
			info = string.Empty;
			return;
		}
		StringBuilder stringBuilder = new StringBuilder(@params * 2);
		GetProgramInfoLog((uint)program, stringBuilder.Capacity, &@params, stringBuilder);
		info = stringBuilder.ToString();
	}

	public static void PointParameter(PointSpriteCoordOriginParameter param)
	{
		PointParameter(PointParameterName.PointSpriteCoordOrigin, (int)param);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib2(int index, ref Vector2 v)
	{
		VertexAttrib2(index, v.X, v.Y);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib3(int index, ref Vector3 v)
	{
		VertexAttrib3(index, v.X, v.Y, v.Z);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib4(int index, ref Vector4 v)
	{
		VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
	}

	public static void VertexAttrib2(int index, Vector2 v)
	{
		VertexAttrib2(index, v.X, v.Y);
	}

	public static void VertexAttrib3(int index, Vector3 v)
	{
		VertexAttrib3(index, v.X, v.Y, v.Z);
	}

	public static void VertexAttrib4(int index, Vector4 v)
	{
		VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
	}

	public static void MultiTexCoord2(TextureUnit target, ref Vector2 v)
	{
		MultiTexCoord2(target, v.X, v.Y);
	}

	public static void MultiTexCoord3(TextureUnit target, ref Vector3 v)
	{
		MultiTexCoord3(target, v.X, v.Y, v.Z);
	}

	public static void MultiTexCoord4(TextureUnit target, ref Vector4 v)
	{
		MultiTexCoord4(target, v.X, v.Y, v.Z, v.W);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib2(int index, ref Vector2d v)
	{
		VertexAttrib2(index, v.X, v.Y);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib3(int index, ref Vector3d v)
	{
		VertexAttrib3(index, v.X, v.Y, v.Z);
	}

	[CLSCompliant(false)]
	public static void VertexAttrib4(int index, ref Vector4d v)
	{
		VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
	}

	public static void VertexAttrib2(int index, Vector2d v)
	{
		VertexAttrib2(index, v.X, v.Y);
	}

	public static void VertexAttrib3(int index, Vector3d v)
	{
		VertexAttrib3(index, v.X, v.Y, v.Z);
	}

	public static void VertexAttrib4(int index, Vector4d v)
	{
		VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
	}

	public static void MultiTexCoord2(TextureUnit target, ref Vector2d v)
	{
		MultiTexCoord2(target, v.X, v.Y);
	}

	public static void MultiTexCoord3(TextureUnit target, ref Vector3d v)
	{
		MultiTexCoord3(target, v.X, v.Y, v.Z);
	}

	public static void MultiTexCoord4(TextureUnit target, ref Vector4d v)
	{
		MultiTexCoord4(target, v.X, v.Y, v.Z, v.W);
	}

	public static void Rect(RectangleF rect)
	{
		Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
	}

	public static void Rect(Rectangle rect)
	{
		Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
	}

	[CLSCompliant(false)]
	public static void Rect(ref RectangleF rect)
	{
		Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
	}

	[CLSCompliant(false)]
	public static void Rect(ref Rectangle rect)
	{
		Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
	}

	public static int GenTexture()
	{
		GenTextures(1, out int textures);
		return textures;
	}

	public static void DeleteTexture(int id)
	{
		DeleteTextures(1, ref id);
	}

	[CLSCompliant(false)]
	public static void DeleteTexture(uint id)
	{
		DeleteTextures(1, ref id);
	}

	public static void VertexPointer(int size, VertexPointerType type, int stride, int offset)
	{
		VertexPointer(size, type, stride, (IntPtr)offset);
	}

	public static void NormalPointer(NormalPointerType type, int stride, int offset)
	{
		NormalPointer(type, stride, (IntPtr)offset);
	}

	public static void IndexPointer(IndexPointerType type, int stride, int offset)
	{
		IndexPointer(type, stride, (IntPtr)offset);
	}

	public static void ColorPointer(int size, ColorPointerType type, int stride, int offset)
	{
		ColorPointer(size, type, stride, (IntPtr)offset);
	}

	public static void FogCoordPointer(FogPointerType type, int stride, int offset)
	{
		FogCoordPointer(type, stride, (IntPtr)offset);
	}

	public static void EdgeFlagPointer(int stride, int offset)
	{
		EdgeFlagPointer(stride, (IntPtr)offset);
	}

	public static void TexCoordPointer(int size, TexCoordPointerType type, int stride, int offset)
	{
		TexCoordPointer(size, type, stride, (IntPtr)offset);
	}

	public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
	{
		VertexAttribPointer(index, size, type, normalized, stride, (IntPtr)offset);
	}

	public static void DrawElements(BeginMode mode, int count, DrawElementsType type, int offset)
	{
		DrawElements(mode, count, type, new IntPtr(offset));
	}

	public unsafe static void GetFloat(GetPName pname, out Vector2 vector)
	{
		fixed (Vector2* @params = &vector)
		{
			GetFloat(pname, (float*)@params);
		}
	}

	public unsafe static void GetFloat(GetPName pname, out Vector3 vector)
	{
		fixed (Vector3* @params = &vector)
		{
			GetFloat(pname, (float*)@params);
		}
	}

	public unsafe static void GetFloat(GetPName pname, out Vector4 vector)
	{
		fixed (Vector4* @params = &vector)
		{
			GetFloat(pname, (float*)@params);
		}
	}

	public unsafe static void GetFloat(GetPName pname, out Matrix4 matrix)
	{
		fixed (Matrix4* @params = &matrix)
		{
			GetFloat(pname, (float*)@params);
		}
	}

	public unsafe static void GetDouble(GetPName pname, out Vector2d vector)
	{
		fixed (Vector2d* @params = &vector)
		{
			GetDouble(pname, (double*)@params);
		}
	}

	public unsafe static void GetDouble(GetPName pname, out Vector3d vector)
	{
		fixed (Vector3d* @params = &vector)
		{
			GetDouble(pname, (double*)@params);
		}
	}

	public unsafe static void GetDouble(GetPName pname, out Vector4d vector)
	{
		fixed (Vector4d* @params = &vector)
		{
			GetDouble(pname, (double*)@params);
		}
	}

	public unsafe static void GetDouble(GetPName pname, out Matrix4d matrix)
	{
		fixed (Matrix4d* @params = &matrix)
		{
			GetDouble(pname, (double*)@params);
		}
	}

	public static void Viewport(Size size)
	{
		Viewport(0, 0, size.Width, size.Height);
	}

	public static void Viewport(Point location, Size size)
	{
		Viewport(location.X, location.Y, size.Width, size.Height);
	}

	public static void Viewport(Rectangle rectangle)
	{
		Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
	}

	public unsafe static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Color color)
	{
		Color4 color2 = new Color4(color.R, color.G, color.B, color.A);
		TexEnv(target, pname, &color2.R);
	}

	public unsafe static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Color4 color)
	{
		TexEnv(target, pname, &color.R);
	}
}
