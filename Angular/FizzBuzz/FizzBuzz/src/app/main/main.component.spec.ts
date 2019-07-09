import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MainComponent } from './main.component';
import { DebugElement } from '@angular/core';

describe('MainComponent', () => {
  let component: MainComponent;
  let fixture: ComponentFixture<MainComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MainComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should render title in a h1 tag', () => {
    const fixture = TestBed.createComponent(MainComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    const selectedThing = compiled.querySelector('h1').textContent;
    expect(selectedThing).toContain('FizzBuzz Kata');
  });

  it('should render first element as 1', () => {
    const fixture: ComponentFixture<MainComponent> = TestBed.createComponent(MainComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    const selectedThing = compiled.querySelector('#output1').textContent;
    expect(selectedThing).toContain('1');
  });

  it('should render third element as Fizz', () => {
    const fixture: ComponentFixture<MainComponent> = TestBed.createComponent(MainComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    const selectedThing = compiled.querySelector('#output3').textContent;
    //console.log(selectedThing);
    expect(selectedThing).toContain('Fizz');
  });

  it('should return five elements', () => {
    const sut: MainComponent = new MainComponent();
    const limit: number = 5;
    const output: string[] = sut.getFizzBuzz(limit);

    expect(output.length).toBe(5);
  });

  it('should return fifth element as Buzz', () => {
    const sut: MainComponent = new MainComponent();
    const limit: number = 5;
    const output: string[] = sut.getFizzBuzz(limit);

    expect(output[4]).toContain('Buzz');
  });

  it('should return fifthteenth element as FizzBuzz', () => {
    const sut: MainComponent = new MainComponent();
    const limit: number = 15;
    const output: string[] = sut.getFizzBuzz(limit);
    console.log(output);
    expect(output[14]).toContain('FizzBuzz');
  });

});
