import { Directive, Input } from '@angular/core';
import {
  AbstractControl,
  NG_VALIDATORS,
  ValidationErrors,
  Validator,
} from '@angular/forms';

@Directive({
  selector: '[appConfirmEqualValidator]',
  providers: [
    {
      provide: NG_VALIDATORS,
      useExisting: ConfirmPasswordValidatorDirective,
      multi: true,
    },
  ],
})
export class ConfirmPasswordValidatorDirective implements Validator {
  //   @Input() appConfirmEqualValidator: string;
  validate(control: AbstractControl): ValidationErrors | null {
    if (control.value === control.parent?.get('accPassword')?.value)
      return null;
    return { notEqual: true };
  }
}
