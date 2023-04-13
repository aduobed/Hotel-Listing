import { OutputTarget } from '../Summary';
import fs from 'fs';

export class HtmlReport implements OutputTarget {
    print(report: string): void {
        const data = `
        <div>
        <h1>Analysis Report</h1>
        <h1>${report}</h1>
        </div>
        `;

        fs.writeFileSync('report.html', data);
    }
}
