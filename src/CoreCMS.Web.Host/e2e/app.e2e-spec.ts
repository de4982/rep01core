import { CoreCMSTemplatePage } from './app.po';

describe('CoreCMS App', function() {
  let page: CoreCMSTemplatePage;

  beforeEach(() => {
    page = new CoreCMSTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
