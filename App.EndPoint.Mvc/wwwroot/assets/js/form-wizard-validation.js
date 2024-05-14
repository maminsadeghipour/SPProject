/**
 *  Form Wizard
 */

'use strict';

(function () {
  const select2 = $('.select2'),
    selectPicker = $('.selectpicker');

  // Wizard Validation
  // --------------------------------------------------------------------
  const wizardValidation = document.querySelector('#wizard-validation');
  if (typeof wizardValidation !== undefined && wizardValidation !== null) {
    // Wizard form
    const wizardValidationForm = wizardValidation.querySelector('#wizard-validation-form');
    // Wizard steps
    const wizardValidationFormStep1 = wizardValidationForm.querySelector('#account-details-validation');
    const wizardValidationFormStep2 = wizardValidationForm.querySelector('#personal-info-validation');
    const wizardValidationFormStep3 = wizardValidationForm.querySelector('#social-links-validation');
    // Wizard next prev button
    const wizardValidationNext = [].slice.call(wizardValidationForm.querySelectorAll('.btn-next'));
    const wizardValidationPrev = [].slice.call(wizardValidationForm.querySelectorAll('.btn-prev'));

    const validationStepper = new Stepper(wizardValidation, {
      linear: true
    });

    // Account details
    const FormValidation1 = FormValidation.formValidation(wizardValidationFormStep1, {
      fields: {
        formValidationUsername: {
          validators: {
            notEmpty: {
              message: 'نام را وارد کنید.'
            },
            stringLength: {
              min: 6,
              max: 30,
              message: 'نام باید بین 6 تا 30 کارکتر باشد'
            },
            regexp: {
              regexp: /^[a-zA-Z0-9 ]+$/,
              message: 'نام فقط باید شامل حروف انگلیسی و اعداد و فاصله باشد'
            }
          }
        },
        formValidationEmail: {
          validators: {
            notEmpty: {
              message: 'ایمیل اجباری است'
            },
            emailAddress: {
              message: 'فرمت ایمیل صحیح نیست'
            }
          }
        },
        formValidationPass: {
          validators: {
            notEmpty: {
              message: 'پسورد اجباری است'
            }
          }
        },
        formValidationConfirmPass: {
          validators: {
            notEmpty: {
              message: 'تایید پسورد اجباری است'
            },
            identical: {
              compare: function () {
                return wizardValidationFormStep1.querySelector('[name="formValidationPass"]').value;
              },
              message: 'پسورد و تایید پسورد یکسان نیستند'
            }
          }
        }
      },
      plugins: {
        trigger: new FormValidation.plugins.Trigger(),
        bootstrap5: new FormValidation.plugins.Bootstrap5({
          // Use this for enabling/changing valid/invalid class
          // eleInvalidClass: '',
          eleValidClass: '',
          rowSelector: '.col-sm-6'
        }),
        autoFocus: new FormValidation.plugins.AutoFocus(),
        submitButton: new FormValidation.plugins.SubmitButton()
      },
      init: instance => {
        instance.on('plugins.message.placed', function (e) {
          //* Move the error message out of the `input-group` element
          if (e.element.parentElement.classList.contains('input-group')) {
            e.element.parentElement.insertAdjacentElement('afterend', e.messageElement);
          }
        });
      }
    }).on('core.form.valid', function () {
      // Jump to the next step when all fields in the current step are valid
      validationStepper.next();
    });

    // Personal info
    const FormValidation2 = FormValidation.formValidation(wizardValidationFormStep2, {
      fields: {
        formValidationFirstName: {
          validators: {
            notEmpty: {
              message: 'نام کوچک الزامی است'
            }
          }
        },
        formValidationLastName: {
          validators: {
            notEmpty: {
              message: 'نام خانوادگی الزامی است'
            }
          }
        },
        formValidationCountry: {
          validators: {
            notEmpty: {
              message: 'کشور الزامی است'
            }
          }
        },
        formValidationLanguage: {
          validators: {
            notEmpty: {
              message: 'زبان الزامی است'
            }
          }
        }
      },
      plugins: {
        trigger: new FormValidation.plugins.Trigger(),
        bootstrap5: new FormValidation.plugins.Bootstrap5({
          // Use this for enabling/changing valid/invalid class
          // eleInvalidClass: '',
          eleValidClass: '',
          rowSelector: '.col-sm-6'
        }),
        autoFocus: new FormValidation.plugins.AutoFocus(),
        submitButton: new FormValidation.plugins.SubmitButton()
      }
    }).on('core.form.valid', function () {
      // Jump to the next step when all fields in the current step are valid
      validationStepper.next();
    });

    // Bootstrap Select (i.e Language select)
    if (selectPicker.length) {
      selectPicker.each(function () {
        var $this = $(this);
        $this.selectpicker().on('change', function () {
          FormValidation2.revalidateField('formValidationLanguage');
        });
      });
    }

    // select2
    if (select2.length) {
      select2.each(function () {
        var $this = $(this);
        $this.wrap('<div class="position-relative"></div>');
        $this
          .select2({
            placeholder: 'انتخاب کشور',
            dropdownParent: $this.parent()
          })
          .on('change.select2', function () {
            // Revalidate the color field when an option is chosen
            FormValidation2.revalidateField('formValidationCountry');
          });
      });
    }

    // Social links
    const FormValidation3 = FormValidation.formValidation(wizardValidationFormStep3, {
      fields: {
        formValidationTwitter: {
          validators: {
            notEmpty: {
              message: 'لینک توییتر الزامی است'
            },
            uri: {
              message: 'فرمت لینک صحیح نیست'
            }
          }
        },
        formValidationFacebook: {
          validators: {
            notEmpty: {
              message: 'لینک فیسبوک الزامی است'
            },
            uri: {
              message: 'فرمت لینک صحیح نیست'
            }
          }
        },
        formValidationGoogle: {
          validators: {
            notEmpty: {
              message: 'لینک گوگل الزامی است'
            },
            uri: {
              message: 'فرمت لینک صحیح نیست'
            }
          }
        },
        formValidationLinkedIn: {
          validators: {
            notEmpty: {
              message: 'لینک لینکدین الزامی است'
            },
            uri: {
              message: 'فرمت لینک صحیح نیست'
            }
          }
        }
      },
      plugins: {
        trigger: new FormValidation.plugins.Trigger(),
        bootstrap5: new FormValidation.plugins.Bootstrap5({
          // Use this for enabling/changing valid/invalid class
          // eleInvalidClass: '',
          eleValidClass: '',
          rowSelector: '.col-sm-6'
        }),
        autoFocus: new FormValidation.plugins.AutoFocus(),
        submitButton: new FormValidation.plugins.SubmitButton()
      }
    }).on('core.form.valid', function () {
      // You can submit the form
      // wizardValidationForm.submit()
      // or send the form data to server via an Ajax request
      // To make the demo simple, I just placed an alert
      alert('ثبت شد..!!');
    });

    wizardValidationNext.forEach(item => {
      item.addEventListener('click', event => {
        // When click the Next button, we will validate the current step
        switch (validationStepper._currentIndex) {
          case 0:
            FormValidation1.validate();
            break;

          case 1:
            FormValidation2.validate();
            break;

          case 2:
            FormValidation3.validate();
            break;

          default:
            break;
        }
      });
    });

    wizardValidationPrev.forEach(item => {
      item.addEventListener('click', event => {
        switch (validationStepper._currentIndex) {
          case 2:
            validationStepper.previous();
            break;

          case 1:
            validationStepper.previous();
            break;

          case 0:

          default:
            break;
        }
      });
    });
  }
})();
