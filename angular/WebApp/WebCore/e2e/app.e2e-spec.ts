import { WebCorePage } from './app.po';

describe('web-core App', () => {
  let page: WebCorePage;

  beforeEach(() => {
    page = new WebCorePage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
