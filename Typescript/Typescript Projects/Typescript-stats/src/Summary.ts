import { MatchData } from './MatchData';
import { HtmlReport } from './reportTargets/HtmlReport';
import { WinsAnalysisReport } from './Analyzer/matchWinsAnalysis';

export interface Analyzer {
    run(matches: MatchData[]): string;
}

export interface OutputTarget {
    print(report: string): void;
}

export class Summary {
    static winsAnalysisWithHtmlReport(team: string): Summary {
        return new Summary(new WinsAnalysisReport(team), new HtmlReport());
    }
    constructor(public analyzer: Analyzer, public outputTarget: OutputTarget) {}

    buildAndPrint(matches: MatchData[]): void {
        const output = this.analyzer.run(matches);
        this.outputTarget.print(output);
    }
}