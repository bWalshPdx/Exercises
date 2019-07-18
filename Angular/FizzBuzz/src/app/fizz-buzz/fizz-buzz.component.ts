import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-fizz-buzz',
  templateUrl: './fizz-buzz.component.html',
  styleUrls: ['./fizz-buzz.component.scss']
})
export class FizzBuzzComponent implements OnInit {

  convertedElements: string[] = ['1', '2', '3'];

  constructor() { }

  GetElement(input: number): string {
    let convertedOutput = '';

    if(input % 3 === 0){
      convertedOutput += 'Fizz';
    }

    if(input % 5 === 0){
      convertedOutput += 'Buzz';
    }

    if(convertedOutput === ''){
      convertedOutput = input.toString();
    }

    return convertedOutput;
  }

  ngOnInit() {
  }

}
