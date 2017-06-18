import { BootAppPage } from './app.po';

describe('boot-app App', () => {
  let page: BootAppPage;

  beforeEach(() => {
    page = new BootAppPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
