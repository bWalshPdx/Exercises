import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FizzBuzzComponent } from './fizz-buzz.component';

describe('FizzBuzzComponent', () => {
  let component: FizzBuzzComponent;
  let fixture: ComponentFixture<FizzBuzzComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FizzBuzzComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FizzBuzzComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('render 1 on label output1', () => {

    const fixture = TestBed.createComponent(FizzBuzzComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('h1').textContent).toContain('Welcome to FizzBuzz!');
  });

  it('should return 1 when passed a 1', () => {
    let sut = new FizzBuzzComponent();
    const input: number = 1;
    const expectedOutput: string = '1';

    const output: string = sut.GetElement(input);

    expect(output).toBe(expectedOutput);

  });

  it('should return Fizz when passed a 3', () => {
    let sut = new FizzBuzzComponent();
    const input: number = 3;
    const expectedOutput: string = 'Fizz';

    const output: string = sut.GetElement(input);

    expect(output).toBe(expectedOutput);

  });

  it('should return Buzz when passed a 5', () => {
    let sut = new FizzBuzzComponent();
    const input: number = 5;
    const expectedOutput: string = 'Buzz';

    const output: string = sut.GetElement(input);

    expect(output).toBe(expectedOutput);

  });

  it('should return FizzBuzz when passed a 15', () => {
    let sut = new FizzBuzzComponent();
    const input: number = 15;
    const expectedOutput: string = 'FizzBuzz';

    const output: string = sut.GetElement(input);

    expect(output).toBe(expectedOutput);

  });

  it('render Fizz on label output3', () => {

  });

  it('render Buzz on label output5', () => {

  });

  it('render FizzBuzz on label output15', () => {

  });

});
