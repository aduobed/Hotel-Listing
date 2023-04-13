import { MatchReader } from './MatchReader';
import { Summary } from './Summary';

const matchReader = MatchReader.fromCsv('football.csv');
const matchSummary = Summary.winsAnalysisWithHtmlReport('Fulham');

matchReader.load();
matchSummary.buildAndPrint(matchReader.matches);
