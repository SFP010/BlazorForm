#pragma checksum "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98c8316c88b0707b357bdb6c3ca2040e11bee5d2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using BlazorForm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using BlazorForm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PatientForm")]
    public partial class PatientForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                  patient

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                                                HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.OpenElement(9, "label");
                __builder2.AddAttribute(10, "for", 
#nullable restore
#line 11 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                     nameof(patient.FirstName)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(11, 
#nullable restore
#line 11 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                 nameof(patient.FirstName)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", 
#nullable restore
#line 12 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                        nameof(patient.FirstName)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                                patient.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => patient.FirstName = __value, patient.FirstName))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => patient.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __Blazor.BlazorForm.Pages.PatientForm.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 13 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                  () => patient.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.OpenElement(25, "label");
                __builder2.AddAttribute(26, "for", 
#nullable restore
#line 17 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                     nameof(patient.LastName)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(27, 
#nullable restore
#line 17 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                nameof(patient.LastName)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "id", 
#nullable restore
#line 18 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                        nameof(patient.LastName)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                               patient.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => patient.LastName = __value, patient.LastName))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => patient.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n        ");
                __Blazor.BlazorForm.Pages.PatientForm.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 19 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                  () => patient.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.OpenElement(41, "label");
                __builder2.AddAttribute(42, "for", 
#nullable restore
#line 23 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                     nameof(patient.BirthDate)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(43, 
#nullable restore
#line 23 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                 nameof(patient.BirthDate)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n        ");
                __Blazor.BlazorForm.Pages.PatientForm.TypeInference.CreateInputDate_2(__builder2, 45, 46, 
#nullable restore
#line 24 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                        nameof(patient.BirthDate)

#line default
#line hidden
#nullable disable
                , 47, "form-control", 48, 
#nullable restore
#line 24 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                                patient.BirthDate

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => patient.BirthDate = __value, patient.BirthDate)), 50, () => patient.BirthDate);
                __builder2.AddMarkupContent(51, "\n        ");
                __Blazor.BlazorForm.Pages.PatientForm.TypeInference.CreateValidationMessage_3(__builder2, 52, 53, 
#nullable restore
#line 25 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                  () => patient.BirthDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n\n    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.OpenElement(57, "label");
                __builder2.AddAttribute(58, "for", 
#nullable restore
#line 29 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                     nameof(patient.Gender)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(59, 
#nullable restore
#line 29 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                              nameof(patient.Gender)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n        ");
                __Blazor.BlazorForm.Pages.PatientForm.TypeInference.CreateInputSelect_4(__builder2, 61, 62, 
#nullable restore
#line 30 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                          nameof(patient.Gender)

#line default
#line hidden
#nullable disable
                , 63, "form-control", 64, 
#nullable restore
#line 30 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                               patient.Gender

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => patient.Gender = __value, patient.Gender)), 66, () => patient.Gender, 67, (__builder3) => {
                    __builder3.AddMarkupContent(68, "<option value>-- Select --</option>\n            ");
                    __builder3.AddMarkupContent(69, "<option value=\"Male\">Male</option>\n            ");
                    __builder3.AddMarkupContent(70, "<option value=\"Female\">Female</option>\n            ");
                    __builder3.AddMarkupContent(71, "<option value=\"They/Them\">They/Them</option>");
                }
                );
                __builder2.AddMarkupContent(72, "\n        ");
                __Blazor.BlazorForm.Pages.PatientForm.TypeInference.CreateValidationMessage_5(__builder2, 73, 74, 
#nullable restore
#line 36 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                  () => patient.Gender

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n\n    ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group");
                __builder2.OpenElement(78, "label");
                __builder2.AddAttribute(79, "for", 
#nullable restore
#line 40 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                     nameof(patient.Email)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(80, 
#nullable restore
#line 40 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                             nameof(patient.Email)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(82);
                __builder2.AddAttribute(83, "id", 
#nullable restore
#line 41 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                        nameof(patient.Email)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(84, "class", "form-control");
                __builder2.AddAttribute(85, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                            patient.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => patient.Email = __value, patient.Email))));
                __builder2.AddAttribute(87, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => patient.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\n        ");
                __Blazor.BlazorForm.Pages.PatientForm.TypeInference.CreateValidationMessage_6(__builder2, 89, 90, 
#nullable restore
#line 42 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                  () => patient.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n\n    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group");
                __builder2.OpenElement(94, "label");
                __builder2.AddAttribute(95, "for", 
#nullable restore
#line 46 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                     nameof(patient.PhoneNumber)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(96, 
#nullable restore
#line 46 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                   nameof(patient.PhoneNumber)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(98);
                __builder2.AddAttribute(99, "id", 
#nullable restore
#line 47 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                        nameof(patient.PhoneNumber)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(100, "class", "form-control");
                __builder2.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                                  patient.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => patient.PhoneNumber = __value, patient.PhoneNumber))));
                __builder2.AddAttribute(103, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => patient.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\n        ");
                __Blazor.BlazorForm.Pages.PatientForm.TypeInference.CreateValidationMessage_7(__builder2, 105, 106, 
#nullable restore
#line 48 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                  () => patient.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\n\n    ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group form-check");
                __builder2.OpenElement(110, "label");
                __builder2.AddAttribute(111, "for", 
#nullable restore
#line 52 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                     nameof(patient.Identification)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(112, "class", "form-check-label");
                __builder2.AddContent(113, 
#nullable restore
#line 52 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                                               nameof(patient.Identification)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(115);
                __builder2.AddAttribute(116, "id", 
#nullable restore
#line 53 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                            nameof(patient.Identification)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(117, "class", "form-check-input");
                __builder2.AddAttribute(118, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 53 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                                                         patient.Identification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(119, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => patient.Identification = __value, patient.Identification))));
                __builder2.AddAttribute(120, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => patient.Identification));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\n        ");
                __Blazor.BlazorForm.Pages.PatientForm.TypeInference.CreateValidationMessage_8(__builder2, 122, 123, 
#nullable restore
#line 54 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
                                  () => patient.Identification

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\n    \n    ");
                __builder2.AddMarkupContent(125, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/PatientForm.razor"
 
    private Patient patient = new Patient();
    

    private async void HandleValidSubmit()
    {
        try
        {
            _context.Patient.Add(patient);
            await _context.SaveChangesAsync();
        }
        catch
        {
            base.StateHasChanged();
        }
        patient = new Patient();
        base.StateHasChanged();
    }
    private void HandleInvalidSubmit()
    {
        Console.WriteLine("You failed.");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorForm.Data.PatientDbContext _context { get; set; }
    }
}
namespace __Blazor.BlazorForm.Pages.PatientForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591