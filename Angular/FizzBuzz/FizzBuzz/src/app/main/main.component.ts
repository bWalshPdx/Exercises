import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {

  //public FizzBuzzCollection: string[] = this.getFizzBuzz(5);

  public FizzBuzzCollection: string[];

  constructor() {
    this.FizzBuzzCollection = this.getFizzBuzz(15);

  }

  ngOnInit() {}

  getFizzBuzz(limit: number): string[] {
    const output: string[] = new Array();

    for (let index = 1; index <= limit; index++) {
      let printLine = '';

      if(index % 3 === 0) {
        printLine += 'Fizz';
      }

      if(index % 5 === 0) {
        printLine += 'Buzz';
      }

      if(printLine === '') {
        printLine = index.toString();
      }

      output.push(printLine);
    }

    return output;
  }
}
